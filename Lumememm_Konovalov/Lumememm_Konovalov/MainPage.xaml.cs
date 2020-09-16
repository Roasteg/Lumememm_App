using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Markup;

namespace Lumememm_Konovalov
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void vis_Clicked(object sender, EventArgs e)
        {
            Lumememm.Opacity = 100;
        }

        private void invis_Clicked(object sender, EventArgs e)
        {
            Lumememm.Opacity = 0;

        }
        Random clr = new Random();
        private void rand_Clicked(object sender, EventArgs e)
        {
            c1.BackgroundColor = Color.FromRgb(clr.Next(0, 255), clr.Next(0,255), 0);
            c2.BackgroundColor = Color.FromRgb(clr.Next(0, 255), clr.Next(0, 255), 0);
            sqr.BackgroundColor = Color.FromRgb(clr.Next(0, 255), clr.Next(0, 255), 0);
        }

        private void opac_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Lumememm.FadeTo(opac.Value);
        }
        private void sz_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            txt.FontSize = txt.FontSize + e.NewValue;
            ;
        }
    }
}
