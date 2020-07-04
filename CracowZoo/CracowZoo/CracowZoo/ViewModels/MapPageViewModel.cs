using CracowZoo.Interfaces;
using CracowZoo.Views;
using Prism.Commands;
using Prism.Events;
using Prism.Navigation;
using System;
using System.Windows.Input;
using Unity;

namespace CracowZoo.ViewModels
{
    public class MapPageViewModel : ViewModelBase
    {
        private readonly IEventAggregator _eventAggregator;
        public ICommand MenuButton { get; }

        private readonly IAnimalTidbitsRepository _animalTidbitsRepository;

        public MapPageViewModel(INavigationService navigationService, IEventAggregator eventAggregator, IAnimalTidbitsRepository animalTidbitsRepository)
            : base(navigationService)
        {
            _eventAggregator = eventAggregator;

            _animalTidbitsRepository = animalTidbitsRepository;

            MenuButton = new DelegateCommand(ShowMenu);
        }

        public override void Initialize(INavigationParameters parameters)
        {
            GetRandomAnimalTidbit();
            base.Initialize(parameters);
        }

        private void ShowMenu()
        {
            _eventAggregator.GetEvent<MyEvent>().Publish();
        }

        private async void GetRandomAnimalTidbit()
        {
            var randomAnimalTidbit = await _animalTidbitsRepository.GetRandomAsync(); //tymczasowo tu, dla testu
        }

    }
}
