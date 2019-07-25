using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace XF_PlanetXamarin.Droid
{
    [Activity(Theme = "@style/MainTheme", 
              MainLauncher = false, 
              ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation,
              ScreenOrientation = ScreenOrientation.Portrait)]
    public partial/*GORILLA*/class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            // DEBUG GORILLA PLAYER EN ANDROID
            // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            var forceXamlOnlyTypeLoading = new[]
            {
                typeof(ImageCircle.Forms.Plugin.Abstractions.CircleImage),
            };
            // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            base.OnCreate(savedInstanceState);

            // ADD CollectionView, etc
            // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            global::Xamarin.Forms.Forms.SetFlags(new[] { "CollectionView_Experimental", "Shell_Experimental" });
            // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            // ADD Init() Material Visual
            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            global::Xamarin.Forms.FormsMaterial.Init(this, savedInstanceState);
            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            // LOTTIE FORMS Init() PARA Android
            // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            //AnimationViewRenderer.Init();
            // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}