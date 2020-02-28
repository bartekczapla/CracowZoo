using CracowZoo.DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CracowZoo.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TasksPage : ContentPage
	{
		public TasksPage ()
		{
			InitializeComponent ();
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