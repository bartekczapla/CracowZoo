using CracowZoo.Core;
using CracowZoo.DataAccess;
using CracowZoo.DataAccess.Entity;
using CracowZoo.DataAccess.Interfaces;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CracowZoo.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly IRepository<Test> _testRepository;
        public ObservableCollection<Test> Tests { get; set; }        


        public MainPageViewModel(INavigationService navigationService, IRepository<Test> testRepository)
            : base(navigationService)
        {
            _testRepository = testRepository;
            Title = "Main Page";

            // Musi byc lepsze rozwiazanie na wywolanie asynchronicznych metod na starcie... 
            Task.Run(async () =>
            {
                var tests = await _testRepository.Get();
                Tests = new ObservableCollection<Test>(tests);

            }).Wait();                             
        }

    }
}
