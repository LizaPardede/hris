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
	public partial class ListIjinEmployee : ContentPage
	{
        string username;
		public ListIjinEmployee (string username)
		{
			InitializeComponent ();
            this.username = username;
		}

        protected override async void OnAppearing() {
            base.OnAppearing();
            if (listIjinEmployee.ItemsSource == null) { }
            listIjinEmployee.ItemsSource = await App.hrManager.GetTOP10DataIjinJSON(username);
            
        }
	}
}
