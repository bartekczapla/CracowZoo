using CracowZoo.DataAccess.Entity;
using CracowZoo.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CracowZoo.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {

            InitializeComponent();
        }

        private async void OnTestTapped(object sender, ItemTappedEventArgs e)
        {

            if (e.Item != null)
            {
                var test = (Test)e.Item;
            }
        }

    }
}