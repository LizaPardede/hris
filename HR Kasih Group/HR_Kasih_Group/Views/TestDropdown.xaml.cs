using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HR_Kasih_Group.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestDropdown : ContentPage
    {
        public TestDropdown()
        {
            InitializeComponent();
        
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            
            //picker.SetBinding(Picker.ItemsSourceProperty, "TypeIjinModel");
            //picker.ItemDisplayBinding = new Binding("Reason");
            pickerIjin.ItemsSource = await App.hrManager.GetDataTypeLemburJSON();
            pickerIjin.ItemDisplayBinding = new Binding("Reason");
        }
    }
}
