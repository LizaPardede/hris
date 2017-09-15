using HR_Kasih_Group.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HR_Kasih_Group
{
    
    public partial class MainPage : TabbedPage
    {
        public string username, idDataLembur;
        public MainPage(string username)
        {
            //InitializeComponent();
            //this.username = username;
            //Debug.WriteLine(username + "mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm");

            var toProfile = new NavigationPage(new ProfileEmployee(username));
            toProfile.Icon = "ic_person_outline_white_24dp.png";

            var toFormLembur = new NavigationPage(new FormLembur(username));
            toFormLembur.Icon = "ic_timelapse_white_24dp.png";

            var toFormIjin = new NavigationPage(new FormIjin(username));
            toFormIjin.Icon = "ic_swap_horiz_white_24dp.png";

            var toListLembur = new NavigationPage(new ListLembur(username));
            toListLembur.Icon = "ic_format_list_bulleted_white_24dp.png";

            var toListIjin = new NavigationPage(new ListIjin(username));
            toListIjin.Icon = "ic_playlist_add_check_white_24dp.png";
           

            Children.Add(toProfile);
            Children.Add(toFormLembur);
            Children.Add(toFormIjin);
            Children.Add(toListLembur);
            Children.Add(toListIjin);

            ToolbarItems.Add(new ToolbarItem("Logout", "ic_logout_outline_navy_24dp.png", async () =>
            {
                var action = await DisplayActionSheet("Are you sure to logout? ", "No", "Yes");
                if (action.Equals("Yes"))
                {
                    App.IsUserLoggedIn = false;
                    App.Current.MainPage = new NavigationPage(new Login());
                    NavigationPage.SetHasNavigationBar(this, false);
                }
                if (action.Equals("No"))
                {

                }
            }));
        }
    }
}
