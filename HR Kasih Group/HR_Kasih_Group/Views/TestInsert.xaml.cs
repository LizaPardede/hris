using HR_Kasih_Group.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HR_Kasih_Group.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TestInsert : ContentPage
	{
        public string empNik, startTime, endTime, description, reason, user, menuId, date, file, selectedValue;
        public DateTime dates;
        private TypeIjinModel _SelectedMotherTounge;


        public TestInsert ()
		{
			InitializeComponent ();       
        }

        public async void OnClickAddButton() {
            DateTime dates = entry_date.Date;
            TimeSpan startTime = entry_start.Time;
            TimeSpan endTime = entry_end.Time;
            description = entry_desc.Text;
            reason = selectedValue;
            file = entry_file.Text;

            var _startTime = startTime.ToString("h':'m':'s''");
            var _endTime = endTime.ToString("h':'m':'s''");

            await App.hrManager.InsertDataIjinJSON("001600064",dates,_startTime,_endTime,description,reason,file,"001600064", "M0098");
        }

        protected override async void OnAppearing() {
            base.OnAppearing();
            picker_reason.ItemsSource = await App.hrManager.GetDataTypeIjinJSON();
            picker_reason.ItemDisplayBinding = new Binding("Reason");
            picker_reason.SelectedIndexChanged += (object sender, EventArgs e) =>
            {
                selectedValue = picker_reason.Items[picker_reason.SelectedIndex];
            };
        }

        
        //public TypeIjinModel SelectedMotherTounge
        //{
        //    get { return _SelectedMotherTounge; }
        //    set
        //    {
        //        //Method which notifies the property change
                
        //        SetProperty(ref _SelectedMotherTounge, value);
        //    }
        //}

        ////fill the observable collection as per requirement
        //public ObservableCollection<TypeIjinModel> Languages = new ObservableCollection<TypeIjinModel>();
        ////Add some items, from DB or service or whatever


        ////Get the selected values - from Languages ObservableCollection
        ////For demo purpose hard-coded value as English, this would the value selected by user.
        //SelectedMotherTounge = GetSelectedItemFromCollection(Languages, "English");

        ////Got the selected item, now get the id from the same
        //var selectedItemId = SelectedMotherTounge.Id;

        ////function to get the selected picker item from the bound collection
        //public static PickerItem
        //GetSelectedItemFromCollection(ObservableCollection<PickerItem> collection, string FindByName)
        //{
        //    PickerItem filteredItems =
        //collection.FirstOrDefault(x => x.Name.ToLower().Trim().Equals(FindByName.ToLower().Trim()));
        //    return filteredItems;
        //}
    }
}

