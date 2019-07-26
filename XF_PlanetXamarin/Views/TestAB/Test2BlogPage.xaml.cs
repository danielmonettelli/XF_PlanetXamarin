using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_PlanetXamarin.ViewModels;

namespace XF_PlanetXamarin.Views.TestAB
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Test2BlogPage : ContentPage
    {
        public Test2BlogPage()
        {
            InitializeComponent();

            BindingContext = new BlogViewModel(Navigation);
        }
    }
}