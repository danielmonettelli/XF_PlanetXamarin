using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XF_PlanetXamarin.Models;
using XF_PlanetXamarin.ViewModels;

namespace XF_PlanetXamarin.Views
{
    public partial class BlogPage : ContentPage
    {
        public BlogPage()
        {
            InitializeComponent();
            //BindingContext = new BlogViewModel();
            BindingContext = new BlogViewModel(Navigation);
        }
    }
}
