using Prism.Navigation;

namespace CracowZoo.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
  
            Title = "Main Page";
                           
        }

    }
}
