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
    public partial class DetailIjin : ContentPage
    {
        string idDataIjin, username;
        public DetailIjin(string idIjin, string uname)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, true);
            this.idDataIjin = idIjin;
            this.username = uname;
        }

        protected override async void OnAppearing (){
            base.OnAppearing();
            detailIjin.ItemsSource = await App.hrManager.GetDataIjinByIDIjinJSON(idDataIjin);
            NavigationPage.SetHasBackButton(this, true);
        }

        public async void OnButtonApproveClicked(object sender, EventArgs args)
        {
            string result = await App.hrManager.ApproveDataIjinJSON(idDataIjin, username);
            Debug.WriteLine(idDataIjin + "Terima");
            Back();
        }

        public async void OnButtonRejectClicked(object sender, EventArgs args)
        {
            string result = await App.hrManager.RejectDataIjinJSON(idDataIjin, username);
            Debug.WriteLine(idDataIjin + "Tolak");
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
