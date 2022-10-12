using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace lab01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Cmdstacklayout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new stacklayout());
        }

        private void Cmdgridlayout1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new gridlayout1());
        }

        private void Cmdgridlayout2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new gridlayout2());
        }

        private void basicControls_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new basicControls());
        }

        private void hadingTheControl_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HandingTheControl());
        }

        private void maytinh_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new maytinh());
        }
    }
}
