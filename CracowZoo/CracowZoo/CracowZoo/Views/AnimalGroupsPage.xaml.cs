using Xamarin.Forms;

namespace CracowZoo.Views
{
    public partial class AnimalGroupsPage : ContentPage
    {
        public AnimalGroupsPage()
        {
            InitializeComponent();
        }

        private void MammalsButton_Released(object sender, System.EventArgs e)
        {
            MammalsButton.Source = "mammalsButton.png";
        }

        private void MammalsButton_Pressed(object sender, System.EventArgs e)
        {
            MammalsButton.Source = "mammalsButtonClicked.png";
        }

        private void AmphibiansButton_Pressed(object sender, System.EventArgs e)
        {
            AmphibiansButton.Source = "amphibiansButtonClicked.png";
        }

        private void AmphibiansButton_Released(object sender, System.EventArgs e)
        {
            AmphibiansButton.Source = "amphibiansButton.png";
        }

        private void ReptilesButton_Pressed(object sender, System.EventArgs e)
        {
            ReptilesButton.Source = "reptilesButtonClicked.png";
        }

        private void ReptilesButton_Released(object sender, System.EventArgs e)
        {
            ReptilesButton.Source = "reptilesButton.png";
        }

        private void BirdsButton_Pressed(object sender, System.EventArgs e)
        {
            BirdsButton.Source = "birdsButtonClicked.png";
        }

        private void BirdsButton_Released(object sender, System.EventArgs e)
        {
            BirdsButton.Source = "birdsButton.png";
        }

        private void FishesButton_Pressed(object sender, System.EventArgs e)
        {
            FishesButton.Source = "fishesButtonClicked.png";
        }

        private void FishesButton_Released(object sender, System.EventArgs e)
        {
            FishesButton.Source = "fishesButton.png";
        }

        private void ScrollView_Scrolled(object sender, ScrolledEventArgs e)
        {
            BirdsButton.Source = "birdsButton.png";
            FishesButton.Source = "fishesButton.png";
            ReptilesButton.Source = "reptilesButton.png";
            AmphibiansButton.Source = "amphibiansButton.png";
            MammalsButton.Source = "mammalsButton.png";
        }
    }
}
