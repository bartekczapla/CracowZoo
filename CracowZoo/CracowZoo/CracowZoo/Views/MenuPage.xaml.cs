using Prism.Events;
using Xamarin.Forms.Xaml;

namespace CracowZoo.Views
{
	public class MyEvent : PubSubEvent { }

	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPage : Xamarin.Forms.MasterDetailPage
	{
		private readonly IEventAggregator _eventAggregator;
		public MenuPage (IEventAggregator eventAggregator)
		{
			_eventAggregator = eventAggregator;

			InitializeComponent();
			_eventAggregator.GetEvent<MyEvent>().Subscribe(GetMessage);
		}

		private void GetMessage()
        {
			IsPresented = !IsPresented;
        }

        private void HideMenuButton_Clicked(object sender, System.EventArgs e)
        {
			IsPresented = false;
        }
    }
}