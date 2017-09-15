using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HR_Kasih_Group.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfileEmployee : ContentPage
    {
        public string username;
        public ProfileEmployee(string username) { 
            InitializeComponent();
            this.username = username;
           
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listProfile.ItemsSource = await App.hrManager.GetProfileEmployeeIDJSON(username);
        }
    }
}
