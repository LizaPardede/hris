using HR_Kasih_Group.Models;
using Newtonsoft.Json.Linq;
using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
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
        public string username, dates, startTime, endTime, reason, description, menuId, file, fileBytee, selectedValue;
        public string resultIjin;
        private MediaFile _mediaFile;

        public byte[] imageAsBytes { get; private set; }

        
      


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
            file = LocalPathLabel.Text;
            

            var _startTime = startTime.ToString("h':'m':'s''");
            var _endTime = endTime.ToString("h':'m':'s''");


            await App.hrManager.InsertDataLemburJSON(username, dates, _startTime, _endTime, reason, description, file, fileBytee, "001600064", "M0097");

        }



        private void OnClickLihatLembur(object sender, SelectedItemChangedEventArgs e)
        {
            var todoPage = new ListLemburEmployee(username);
            Debug.WriteLine(Id);
            Navigation.PushAsync(todoPage);
        }

        private async void PickPhoto_Clicked(object sender, EventArgs e)
        {
            try
            {
                await CrossMedia.Current.Initialize();

                if (!CrossMedia.Current.IsPickPhotoSupported)
                {
                    await DisplayAlert("No PickPhoto", ":( No PickPhoto available.", "OK");
                    return;
                }

                _mediaFile = await CrossMedia.Current.PickPhotoAsync();

                if (_mediaFile == null)
                    return;

                LocalPathLabel.Text = _mediaFile.Path;

                FileImage.Source = ImageSource.FromStream(() =>
                {
                    return _mediaFile.GetStream();
                });

                

                using (var memoryStream = new MemoryStream())
                {
                    _mediaFile.GetStream().CopyTo(memoryStream);
                    _mediaFile.Dispose();
                    imageAsBytes = memoryStream.ToArray();
                    
                    var byteArray = memoryStream.ToArray();
                    string base64String = Convert.ToBase64String(byteArray);
                    fileBytee = base64String;

                    Debug.WriteLine(fileBytee + "mmmmmmmmmmmmmmmmmmmmmmmmmm");

                }






            }
            catch (Exception a)
            {
                Debug.WriteLine(a.Message);
                Debug.WriteLine("eeeeeeeeeeeeeeeeeeeeeeeeeeeeee");
            }
        }


        

    }
}
