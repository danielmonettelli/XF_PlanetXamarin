using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace XF_PlanetXamarin.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            // ADD CollectionView, etc
            // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            global::Xamarin.Forms.Forms.SetFlags(new[] { "CollectionView_Experimental", "Shell_Experimental" });
            // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            global::Xamarin.Forms.Forms.Init();

            // ADD Init() Material Visual
            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            global::Xamarin.Forms.FormsMaterial.Init();
            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            // DEBUG GORILLA PLAYER EN iOS
            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            var forceXamlOnlyTypeLoading = new[]
            {
                typeof(ImageCircle.Forms.Plugin.Abstractions.CircleImage),
            };
            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            // LOTTIE FORMS Init() PARA iOS
            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            //AnimationViewRenderer.Init();
            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
