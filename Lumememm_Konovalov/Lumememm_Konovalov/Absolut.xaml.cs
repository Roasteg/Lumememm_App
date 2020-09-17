using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lumememm_Konovalov
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Absolut : ContentPage
    {
        public Absolut()
        {
            InitializeComponent();
        }

        private void inv_Clicked(object sender, EventArgs e)
        {
            c1.Opacity = 0;
            c2.Opacity = 0;
            sqr.Opacity = 0;
        }

        private void vis_Clicked(object sender, EventArgs e)
        {
            c1.Opacity = 1;
            c2.Opacity = 1;
            sqr.Opacity = 1;
        }

        private void fade_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            c1.FadeTo(fade.Value);
            c2.FadeTo(fade.Value);
            sqr.FadeTo(fade.Value);
        }
    }
}