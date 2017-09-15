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
    public partial class DetailLembur : ContentPage
    {
        string idDataLembur, username;

        public DetailLembur(string idLembur, string uname) 
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, true);
            this.idDataLembur = idLembur;
            this.username = uname;
        }

        protected override async void OnAppearing() {
            base.OnAppearing();
            detailLembur.ItemsSource = await App.hrManager.GetDataLemburByIDLemburJSON(idDataLembur);
            NavigationPage.SetHasBackButton(this, true);
        }

        public async void OnButtonApproveClicked(object sender, EventArgs args)
        {
            string result = await App.hrManager.ApproveDataIjinJSON(idDataLembur, username);
            Back();
        }

        public async void OnButtonRejectClicked(object sender, EventArgs args)
        {
            string result = await App.hrManager.RejectDataIjinJSON(idDataLembur, username);
            Back();
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
