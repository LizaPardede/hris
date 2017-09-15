using HR_Kasih_Group.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HR_Kasih_Group.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FormLembur : ContentPage
    {
        public string username, dates, startTime, endTime, reason, description, menuId, file, selectedValue;
        public string resultIjin;
        

        public FormLembur(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        //Property to hold the selected picker item


        protected override async void OnAppearing()
        {
            base.OnAppearing();
            pickerReason.ItemsSource = await App.hrManager.GetDataTypeLemburJSON();
            pickerReason.ItemDisplayBinding = new Binding("Reason");
            pickerReason.SelectedItem = new Binding("ID");



            pickerReason.SelectedIndexChanged += (object sender, EventArgs e) =>
            {

                selectedValue = pickerReason.Items[pickerReason.SelectedIndex];
                Debug.WriteLine(selectedValue + "zzzzzzzzzzzzzzzzzzzzzzzzzzzzzz");

            };


        }

        private async void OnClickAddButton(object sender, EventArgs e)
        {
            DateTime dates = dpDate.Date;
            TimeSpan startTime = tpStart.Time;
            TimeSpan endTime = tpEnd.Time;
            reason = selectedValue;
            description = entryDescription.Text;
            file = entryFile.Text;

            var _startTime = startTime.ToString("h':'m':'s''");
            var _endTime = endTime.ToString("h':'m':'s''");

            await App.hrManager.InsertDataLemburJSON("001600064", dates, _startTime, _endTime, reason, description, file, "001600064", "M0097");

        }



        private void OnClickLihatLembur(object sender, SelectedItemChangedEventArgs e)
        {
            var todoPage = new ListLemburEmployee(username);
            Debug.WriteLine(Id);
            Navigation.PushAsync(todoPage);
        }


    }
}
