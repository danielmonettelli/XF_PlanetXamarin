using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XF_PlanetXamarin.ViewModels;

namespace XF_PlanetXamarin.Views
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
            BindingContext = new BlogViewModel(Navigation);
        }

        //private async void Button_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new TestAB.Test2BlogPage());
        //    //await Navigation.PushAsync(new BlogPage());
        //}
    }
}
