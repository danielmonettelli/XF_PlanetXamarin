using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XF_PlanetXamarin.Models;
using XF_PlanetXamarin.Services;
using XF_PlanetXamarin.Views;
using XF_PlanetXamarin.Views.TestAB;

namespace XF_PlanetXamarin.ViewModels
{
    public class BlogViewModel : INotifyPropertyChanged
    {
        #region Interfaces
        INavigation _navigation;
        #endregion

        #region Properties
        private bool _isBusy = false;

        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                _isBusy = value;
                OnPropertyChanged();
            }
        }


        private List<Publication> _listPublications;

        public List<Publication> ListPublications
        {
            get { return _listPublications; }
            set
            {
                _listPublications = value;
                OnPropertyChanged();
            }
        }
       
        public Publication Publication { get; set; }
        #endregion

        #region Commands
        public Command NextDescriptionBlogPageCommand { get; set; }
        public Command NextBlogPageCommand { get; set; }
        #endregion

        #region Constructors
        public BlogViewModel(INavigation navigation)
        {
            this._navigation = navigation;
         
            GetService();

            NextDescriptionBlogPageCommand = new Command(async () =>
              await ToDescriptionBlogPage(), canExecute: () => !IsBusy);

            NextBlogPageCommand = new Command(async () =>
           await ToBlogPage(), canExecute: () => !IsBusy);
        }
        public BlogViewModel()
        {
            //GetService();
        }
        #endregion

        #region Tasks

        private async Task ToDescriptionBlogPage()
        {
            await _navigation.PushAsync(new DescriptionBlogPage(Publication));
        }

        private async Task ToBlogPage()
        {
            IsBusy = true;
            await Task.Delay(1000);
            await _navigation.PushAsync(new Test2BlogPage());
            IsBusy = false;
        }
        #endregion

        #region CRUD Services
        public void GetService()
        {
            var service = new PublicationsService();
            ListPublications = service.GetPublication();
        }
        #endregion

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
