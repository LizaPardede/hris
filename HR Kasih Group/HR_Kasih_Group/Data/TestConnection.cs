using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Kasih_Group.Data
{
    public class TestConnection
    {
        string returnConnection;

        public async Task<string> CheckConnection()
        {
            string result = await App.hrManager.TestConnection();
            Debug.WriteLine("TestKoneksiAwal");
            if (result.Contains("error-connection"))
            {
                returnConnection = "NotConnected";
                Debug.WriteLine("TestConnection Gagal");
            }


            else if (result.Contains("Department_Name"))
            {
                returnConnection = "Connected";
                Debug.WriteLine("TestConnection Berhasil");
            }
            else
            {
                returnConnection = "Connected";
                Debug.WriteLine("TestConnection Success");
            }
            //Debug.WriteLine("returnConnection");

            return returnConnection;

        }
    }
}
