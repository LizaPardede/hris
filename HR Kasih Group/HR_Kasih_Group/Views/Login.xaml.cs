using HR_Kasih_Group.Data;
using HR_Kasih_Group.Models;
using Newtonsoft.Json.Linq;
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
    public partial class Login : ContentPage
    {
        TestConnection checkConnection = new TestConnection();
        public string testKoneksi, username, password;

        public Login()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();

            var conten = new ContentPage
            {
                Title = "FormExample"
            };
        }

        public async void OnClickLoginButton()
        {
            testKoneksi = await checkConnection.CheckConnection();

            if (testKoneksi.Equals("Connected"))
            {
                var Username = Entry_UserName.Text;
                var Password = Entry_Password.Text;

                await App.hrManager.AutentikasiUserJSON(Username, Password);
                await Navigation.PopAsync();

                string result = await App.hrManager.AutentikasiUserJSON(Username, Password);

                if (result.Contains("Emp_ID") || result.Contains("Password"))
                {
                    string idEmp = " ", pw = " ";
                    JArray jArray = JArray.Parse(result);

                    foreach (JObject o in jArray.Children<JObject>())
                    {
                        foreach (JProperty p in o.Properties())
                        {
                            string name = p.Name;
                            string value = (string)p.Value;
                            idEmp = o["Emp_ID"].ToString();
                            pw = o["Password"].ToString();
                            username = idEmp;
                            password = pw;
                        }
                    }

                    var dataEmp = new User
                    {
                        Emp_ID = idEmp,
                        Password = pw
                    };

                    App.IsUserLoggedIn = true;
                    Debug.WriteLine(username + "zzzzzzzzzzzzzzzz");

                    await Navigation.PushModalAsync(new MainPage(username));
                }

                else
                {
                    Lbl_Error.Text = "Login Failed";
                }
            }
            else
            {
                await Navigation.PopModalAsync();
                await DisplayAlert("Connection Error", "Please check your internet connection or try again later", "OK");
            }
        }

        public async void testConnections()
        {
            testKoneksi = await checkConnection.CheckConnection();
            if (testKoneksi.Equals("Connected"))
            {
                Debug.WriteLine("berhasil fungsi");
                OnClickLoginButton();
            }
            else
            {
                Debug.WriteLine("gag fungsi");
                await DisplayAlert("Connection Error", "Please check your internet connection or try again later", "OK");
            }
        }

        void OnLoginButtonClicked(object sender, EventArgs e)
        {
            testConnections();
        }
    }
}
