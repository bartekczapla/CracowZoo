using CracowZoo.DataAccess.Interfaces;
using CracowZoo.Models;
using Prism.Navigation;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace CracowZoo.ViewModels
{
    public class TasksPageViewModel : ViewModelBase
    {
        private readonly IRepository<Test> _testRepository;
        public ObservableCollection<Test> Tests { get; set; }


        public TasksPageViewModel(INavigationService navigationService, IRepository<Test> testRepository)
            : base(navigationService)
        {
            _testRepository = testRepository;
            Title = "Tasks Page";

            InitializeAsync();
        }

        public async void InitializeAsync()
        {
            var tests = await _testRepository.Get();
            Tests = new ObservableCollection<Test>(tests);
        }
    }
}
