using System;

using Xamarin.Forms;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

namespace ltl96
{
    public class App : Application
    {
        public App()
        {
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
			// Handle when your app starts
			MobileCenter.Start("ios=c82e2461-17e5-41dc-ae79-12c40feadee6;" +
				   "android=3a7eb169-a8c6-4b0f-9aba-f6621edc3b17;",
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
