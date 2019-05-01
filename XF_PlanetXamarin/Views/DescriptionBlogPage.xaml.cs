using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XF_PlanetXamarin.Models;
using XF_PlanetXamarin.ViewModels;

namespace XF_PlanetXamarin.Views
{
    public partial class DescriptionBlogPage : ContentPage
    {

        public DescriptionBlogPage(Publication toPublication)
        {
            InitializeComponent();

            BindingContext = toPublication;
        }
    }
}
