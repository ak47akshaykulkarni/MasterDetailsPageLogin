using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MasterDetailsPageLogin
{
    public class App : Application
    {
        public App()
        {
            App.Current.MainPage = new NavigationPage(new Views.Login())
            {
                BarBackgroundColor = Color.FromHex("#8999A6"),
                BarTextColor = Color.White
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
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
