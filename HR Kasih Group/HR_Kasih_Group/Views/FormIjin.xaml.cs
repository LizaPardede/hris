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
    public partial class FormIjin : ContentPage
    {
        public string username, startTime, endTime, description, reason, user, menuId, date, file, selectedValue;
        public FormIjin(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        protected override async void OnAppearing() {
            base.OnAppearing();
            pickerReason.ItemsSource = await App.hrManager.GetDataTypeIjinJSON();
            pickerReason.ItemDisplayBinding = new Binding("Reason");
            pickerReason.SelectedIndexChanged += (object sender, EventArgs e) =>
            {
                selectedValue = pickerReason.Items[pickerReason.SelectedIndex];
            };
        }

        public async void OnClickAddButton() {
            DateTime dates = dpDate.Date;
            TimeSpan startTime = tpStart.Time;
            TimeSpan endTime = tpEnd.Time;
            reason = selectedValue;
            description = entryDescription.Text;
            file = entryFile.Text;

            var _startTime = startTime.ToString("h':'m':'s''");
            var _endTime = endTime.ToString("h':'m':'s''");

            await App.hrManager.InsertDataIjinJSON(username,dates,_startTime,_endTime,description,reason,file,username,"M0098");
        }

        private void OnClickLihatIjin(object sender, SelectedItemChangedEventArgs e)
        {
            var todoPage = new ListIjinEmployee(username);
            Debug.WriteLine(Id);
            Navigation.PushAsync(todoPage);
        }
    }
}
