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

        private void SearchEntry_Unfocused(object sender, FocusEventArgs e)
        {
            FoundAnimalsListView.IsVisible = false;
        }

        private void SearchEntry_Focused(object sender, FocusEventArgs e)
        {
            if (string.IsNullOrEmpty(SearchEntry?.Text))
                return;

            FoundAnimalsListView.IsVisible = SearchEntry.Text.Length > 0;
        }
    }
}
