using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Graphics.Drawables;
using Android.Content;
using CracowZoo.Views.CustomControls;
using CracowZoo.Droid.CustomRenderers;
using System.Drawing;

[assembly: ExportRenderer(typeof(EntryNoUnderline), typeof(EntryNoUnderlineRenderer))]
namespace CracowZoo.Droid.CustomRenderers
{
    public class EntryNoUnderlineRenderer : EntryRenderer
    {
        public EntryNoUnderlineRenderer(Context context) : base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.SetPadding(50, 30, 50, 30);
                GradientDrawable gd = new GradientDrawable();
                gd.SetColor(Android.Graphics.Color.White);
                gd.SetCornerRadius(100);
                gd.SetStroke(2, Android.Graphics.Color.Gray);
                Control.Background = gd;
            }
        }
    }
}