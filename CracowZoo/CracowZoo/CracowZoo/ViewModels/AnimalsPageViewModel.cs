﻿using CracowZoo.Enums;
using CracowZoo.Helpers;
using CracowZoo.Interfaces;
using CracowZoo.Models;
using CracowZoo.Models.Aditionals;
using CracowZoo.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using static CracowZoo.Helpers.EnumHelper;

namespace CracowZoo.ViewModels
{
    public class AnimalsPageViewModel : ViewModelBase
    {
        private readonly IRepository _repository;
        public int AnimalGroup { get; set; }
        public int? MapItemId { get; set; }
        private bool _isNavigating;
        public ObservableCollection<Animal> Animals { get; } = new ObservableCollection<Animal>();

        private Animal _selectedAnimal;
        public Animal SelectedAnimal
        {
            get => _selectedAnimal;
            set
            {
                SetProperty(ref _selectedAnimal, value);
                if(value != null)
                {
                    NavigateToAnimalDetails();
                }           
            }
        }

        private bool _pageLoading = true;
        public bool PageLoading
        {
            get => _pageLoading;
            set => SetProperty(ref _pageLoading, value);
        }
 
        public AnimalsPageViewModel(INavigationService navigationService, IRepository repository)
            :base(navigationService)
        {
            _repository = repository;
            Title = "Zwierzęta";
            AnimalGroup = -1;
            MapItemId = null;
        }

        public override async void OnNavigatedTo(INavigationParameters parameters)
        {
            _isNavigating = false;
            PageLoading = true;

            IEnumerable<Animal> animals = new List<Animal>();
            if (parameters.ContainsKey("animalGroup"))
            {
                AnimalGroup = parameters.GetValue<int>("animalGroup");
                animals = await GetAnimalsByAnimalGroup();
            } else if (parameters.ContainsKey("mapItemId"))
            {
                MapItemId = parameters.GetValue<int>("mapItemId");
                animals = await GetAnimalsByMapItemId();
            }
            Animals.AddCollection(animals);

            PageLoading = false;
            SelectedAnimal = null;         
            base.OnNavigatedTo(parameters);
        }

        private async Task<IEnumerable<Animal>> GetAnimalsByAnimalGroup()
        {
            if (AnimalGroup > 0)
            {
                return await _repository.GetManyAsync<Animal>((Animal entity) => 
                        entity.Group == (AnimalGroup)AnimalGroup, new OrderElementDescription("Name", true), 
                        new string[] { "MapItem", "AnimalTidbits" });
                
            } else
            {
                return await _repository.GetManyAsync<Animal>(null, new OrderElementDescription("Name", true),
                        new string[] { "MapItem", "AnimalTidbits" });
            }
        }

        private async Task<IEnumerable<Animal>> GetAnimalsByMapItemId()
        {
            return await _repository.GetManyAsync<Animal>((Animal entity) =>
                    entity.MapItemId == MapItemId, new OrderElementDescription("Name", true),
                    new string[] { "MapItem", "AnimalTidbits" });
        }

        async void NavigateToAnimalDetails()
        {
            if (_isNavigating)
                return;

            _isNavigating = true;

            var parameters = new NavigationParameters();
            parameters.Add("selectedAnimal", SelectedAnimal);
            await NavigationService.NavigateAsync(nameof(AnimalDetailsPage), parameters);
        }
    }
}
