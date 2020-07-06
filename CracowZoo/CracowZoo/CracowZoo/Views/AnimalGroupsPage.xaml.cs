using Xamarin.Forms;

namespace CracowZoo.Views
{
    public partial class AnimalGroupsPage : ContentPage
    {
        public AnimalGroupsPage()
        {
            InitializeComponent();
        }

        private void SearchEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            FoundAnimalsListView.IsVisible = e.NewTextValue.Length > 0;
        }
    }
}
