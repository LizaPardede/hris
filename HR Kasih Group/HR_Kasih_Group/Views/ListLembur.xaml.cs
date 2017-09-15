using HR_Kasih_Group.Models;
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
    public partial class ListLembur : ContentPage
    {
        string username;
        public ListLembur(string username)
        {
            
            this.username = username;
            NavigationPage.SetHasNavigationBar(this, true);
            InitializeComponent();
            
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listDataLembur.ItemsSource = await App.hrManager.GetDataLemburByHeadJSON(username);
        }

        private void OnClickLemburItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (listDataLembur.SelectedItem == null) return;
            var dataLembur = (LemburModel)e.SelectedItem;
            string idDataLembur = dataLembur.ID;

            var todoPage = new DetailLembur(idDataLembur, username);
            Debug.WriteLine(Id);
            todoPage.BindingContext = dataLembur;
            Navigation.PushAsync(todoPage);

        }

        public async void Back()
        {
            await Navigation.PopAsync();
        }

        protected override bool OnBackButtonPressed()
        {
            Back();
            return true;
        }
    }
}
