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
	public partial class ListLemburEmployee : ContentPage
	{
        string username;
		public ListLemburEmployee (string username)
		{
			InitializeComponent ();
            this.username = username;
		}

        protected override async void OnAppearing() {
            base.OnAppearing();
            listLemburEmployee.ItemsSource = await App.hrManager.GetTop10DataLemburJSON(username);
        }
	}
}
