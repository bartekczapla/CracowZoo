using CracowZoo.Interfaces;
using CracowZoo.Views;
using Prism.Commands;
using Prism.Events;
using Prism.Navigation;
using System;
using System.Windows.Input;

namespace CracowZoo.ViewModels
{
    public class MapPageViewModel : ViewModelBase
    {
        private readonly IEventAggregator _eventAggregator;

        private readonly IAnimalTidbitsRepository _animalTidbitsRepository;

        public MapPageViewModel(INavigationService navigationService, IEventAggregator eventAggregator, IAnimalTidbitsRepository animalTidbitsRepository)
            : base(navigationService)
        {
            _eventAggregator = eventAggregator;
            _animalTidbitsRepository = animalTidbitsRepository;   
        }

        public override void Initialize(INavigationParameters parameters)
        {
            base.Initialize(parameters);
        }

        private async void GetRandomAnimalTidbit()
        {
            var randomAnimalTidbit = await _animalTidbitsRepository.GetRandomAsync();
        }

    }
}
