using HR_Kasih_Group.Data;
using HR_Kasih_Group.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace HR_Kasih_Group
{
    public partial class App : Application
    {
        public static HrManager hrManager { get; set; }
        public static bool IsUserLoggedIn { get; set; }

        public App()
        {
            hrManager = new HrManager(new RestService());
            if (!IsUserLoggedIn) {
                MainPage = new NavigationPage(new Login());
            }
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
