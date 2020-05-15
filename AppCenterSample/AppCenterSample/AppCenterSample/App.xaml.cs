using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;

namespace AppCenterSample
{
    public partial class App : Application
    {
        const string uwpKey = "2b977979-ebbc-40f8-b6d2-cddb98312ac1";
        const string iosKey = "165abd2a-64d3-4371-ba02-d3cc5a1f9d61";
        const string androidKey = "ab0d38a2-dd51-4c8d-bc77-1b154b628441";
        // hoge

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            AppCenter.Start($"uwp={uwpKey};android={androidKey};ios={iosKey};", 
                typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
