﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CracowZoo.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPage : Xamarin.Forms.MasterDetailPage
	{
		public MenuPage ()
		{
			InitializeComponent ();
		}
	}
}