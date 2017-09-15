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
    public partial class ListIjin : ContentPage
    {
        string username;
        public ListIjin(string username)
        {
            this.username = username;
             InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listDataIjin.ItemsSource = await App.hrManager.GetDataIjinByHeadJSON(username);
        }

        private void OnClickIjinItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (listDataIjin.SelectedItem == null) return;
            var dataIjin = (IjinModel)e.SelectedItem;
            string idDataIjin = dataIjin.ID;

            var todoPage = new DetailIjin(idDataIjin, username);
            Debug.WriteLine(Id);
            todoPage.BindingContext = dataIjin;
            Navigation.PushAsync(todoPage);
       }
    }
}
