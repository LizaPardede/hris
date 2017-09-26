using HR_Kasih_Group.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace HR_Kasih_Group.Data
{
    public class RestService : IRestService
    {
        HttpClient client;

        public List<CareerModel> mCareer { get; private set; }
        public List<DepartmentModel> mDepartment { get; private set; }
        public List<EducationModel> mEducation { get; private set; }
        public List<EmployeeModel> mEmployee { get; private set; }
        public List<ExperienceModel> mExperience { get; private set; }
        public List<IjinModel> mIjin { get; private set; }
        public List<InboxModel> mInbox { get; private set; }
        public List<LemburModel> mLembur { get; private set; }
        public List<ScheduleModel> mSchedule { get; private set; }
        public List<TrainingModel> mTraining { get; private set; }
        public List<TypeIjinModel> mTypeIjin { get; private set; }
        public List<TypeLemburModel> mTypeLembur { get; private set; }
        public List<IjinTop10Model> mTop10ijin { get; private set; }
        public List<LemburTop10Model> mTop10Lembur { get; private set; }


        public string testConnection, resultLogin, resultEmployee, resultDataIjin, resultDataLembur,
            resultUpdateIjin, resultUpdateLembur, resultApprove, resultReject;

        public RestService()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
        }

        public async Task<string> TestConnection()
        {
            var uri = new Uri(string.Format(Constant.GetDataDeparment, string.Empty));
            Debug.WriteLine(uri);
            Debug.WriteLine("test url " + Constant.GetDataDeparment);
            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    testConnection = await response.Content.ReadAsStringAsync();
                    Debug.WriteLine("RestService Success");
                }
                else
                {
                    testConnection = "error-connection";
                    Debug.WriteLine("RestService Gagal");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                testConnection = "error-connection";
            }
            return testConnection;
        }

        public async Task<string> AutentikasiUserJSON(string Emp_ID, string Password)
        {
            var uri = new Uri(string.Format(Constant.AutentikasiUserJSON + Emp_ID + "&sPassword=" + Password, string.Empty));
            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    resultLogin = await response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }
            return resultLogin;
        }

        public async Task<string> ApproveDataIjinJSON(string id, string user)
        {
            var uri = new Uri(string.Format(Constant.ApproveDataIjin + id + "&sUser=" + user, string.Empty));
            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    resultApprove = await response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }
            return resultReject;
        }

        public async Task<string> RejectDataIjinJSON(string id, string user)
        {
            var uri = new Uri(string.Format(Constant.RejectDataIjinJSON + id + "&sUser=" + user, string.Empty));
            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    resultReject = await response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }
            return resultReject;
        }

        public async Task<string> ApproveDataLemburJSON(string id, string user)
        {
            var uri = new Uri(string.Format(Constant.ApproveDataLembur + id + "&sUser=" + user, string.Empty));
            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    resultApprove = await response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }
            return resultReject;
        }

        public async Task<string> RejectDataLemburJSON(string id, string user)
        {
            var uri = new Uri(string.Format(Constant.RejectDataLemburJSON + id + "&sUser=" + user, string.Empty));
            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    resultReject = await response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }
            return resultReject;
        }

        public async Task<List<CareerModel>> GetDataCareerJSON(string empId)
        {
            mCareer = new List<CareerModel>();
            var uri = new Uri(string.Format(Constant.GetDataCareer + empId, string.Empty));

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    mCareer = JsonConvert.DeserializeObject<List<CareerModel>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }
            return mCareer;

        }

        public async Task<List<DepartmentModel>> GetDataDepartmentByEmployeeIDJSON(string empId)
        {
            mDepartment = new List<DepartmentModel>();

            var uri = new Uri(string.Format(Constant.GetDataDepartmentById + empId, string.Empty));

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    mDepartment = JsonConvert.DeserializeObject<List<DepartmentModel>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }
            return mDepartment;
        }

        public async Task<List<EducationModel>> GetDataEducationJSON(string empId)
        {
            mEducation = new List<EducationModel>();

            var uri = new Uri(string.Format(Constant.GetDataEducation + empId, string.Empty));

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    mEducation = JsonConvert.DeserializeObject<List<EducationModel>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }
            return mEducation;
        }

        public async Task<List<EmployeeModel>> GetDataEmployeeJSON(string empId)
        {
            mEmployee = new List<EmployeeModel>();

            var uri = new Uri(string.Format(Constant.GetDataEmployee + empId, string.Empty));

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    mEmployee = JsonConvert.DeserializeObject<List<EmployeeModel>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }
            return mEmployee;
        }

        public async Task<List<ExperienceModel>> GetDataExperienceJSON(string empId)
        {
            mExperience = new List<ExperienceModel>();

            var uri = new Uri(string.Format(Constant.GetDataExperience + empId, string.Empty));

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    mExperience = JsonConvert.DeserializeObject<List<ExperienceModel>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }
            return mExperience;
        }

        public async Task<List<IjinModel>> GetDataIjinByHeadJSON(string headId)
        {
            mIjin = new List<IjinModel>();

            var uri = new Uri(string.Format(Constant.GetDataIjinByHead + headId, string.Empty));
            Debug.WriteLine(uri);
            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    mIjin = JsonConvert.DeserializeObject<List<IjinModel>>(content);
                    //gimana looping disini wkwkwk looping list ini lah bisa kan wkkwkw
                    //kenapa harus looping isi listnya kan lebih dari satu pak cik , jadi biar kita cek dalamnya, kalau kosong kita kasih -
                    //ga jadi berat kali itu cuma buat nambah - makanya tadi kutanya dimana set data ke listnya pak cik
                    //inii, mana ? maksudku set data ke listviewnya
                    
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }
            return mIjin;
        }

        public async Task<List<IjinModel>> GetDataIjinByIDIjinJSON(string ijinId)
        {
            mIjin = new List<IjinModel>();

            var uri = new Uri(string.Format(Constant.GetDataIjinByIDIjin + ijinId, string.Empty));

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    mIjin = JsonConvert.DeserializeObject<List<IjinModel>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }
            return mIjin;
        }

        public async Task<List<LemburModel>> GetDataLemburByHeadJSON(string headId)
        {
            mLembur = new List<LemburModel>();

            var uri = new Uri(string.Format(Constant.GetDataLemburByHead + headId, string.Empty));
            Debug.WriteLine(uri);

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    mLembur = JsonConvert.DeserializeObject<List<LemburModel>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }
            return mLembur;

        }

        public async Task<List<LemburModel>> GetDataLemburByIDLemburJSON(string lemburID)
        {
            mLembur = new List<LemburModel>();

            var uri = new Uri(string.Format(Constant.GetDataLemburByIDLembur + lemburID, string.Empty));
            Debug.WriteLine(uri);

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    mLembur = JsonConvert.DeserializeObject<List<LemburModel>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }
            return mLembur;
        }

        public async Task<List<DepartmentModel>> GetDataDepartmentJSON()
        {
            mDepartment = new List<DepartmentModel>();

            var uri = new Uri(string.Format(Constant.GetDataDeparment, string.Empty));
            Debug.WriteLine(uri);

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    mDepartment = JsonConvert.DeserializeObject<List<DepartmentModel>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }
            return mDepartment;
        }

        public async Task<List<ScheduleModel>> GetDataScheduleJSON(string empId)
        {
            mSchedule = new List<ScheduleModel>();

            var uri = new Uri(string.Format(Constant.GetDataSchedule + empId, string.Empty));

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    mSchedule = JsonConvert.DeserializeObject<List<ScheduleModel>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }
            return mSchedule;

        }

        public async Task<List<TrainingModel>> GetDataTrainingJSON(string empId)
        {
            mTraining = new List<TrainingModel>();

            var uri = new Uri(string.Format(Constant.GetDataTraining + empId, string.Empty));

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    mTraining = JsonConvert.DeserializeObject<List<TrainingModel>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }
            return mTraining;
        }

        public async Task<List<TypeIjinModel>> GetDataTypeIjinJSON()
        {
            mTypeIjin = new List<TypeIjinModel>();

            var uri = new Uri(string.Format(Constant.GetDataTypeIjin, string.Empty));

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    mTypeIjin = JsonConvert.DeserializeObject<List<TypeIjinModel>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }
            return mTypeIjin;
        }

        public async Task<List<TypeLemburModel>> GetDataTypeLemburJSON()
        {
            mTypeLembur = new List<TypeLemburModel>();

            var uri = new Uri(string.Format(Constant.GetDataTypeLembur, string.Empty));
            Debug.WriteLine(uri);

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    mTypeLembur = JsonConvert.DeserializeObject<List<TypeLemburModel>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }
            return mTypeLembur;

        }

        public async Task<List<InboxModel>> GetInboxHeadJSON(string userId)
        {
            mInbox = new List<InboxModel>();

            var uri = new Uri(string.Format(Constant.GetInboxHeadJSON + userId, string.Empty));

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    mInbox = JsonConvert.DeserializeObject<List<InboxModel>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }
            return mInbox;
        }

        public async Task<List<EmployeeModel>> GetProfileEmployeeIDJSON(string empId)
        {
            mEmployee = new List<EmployeeModel>();

            var uri = new Uri(string.Format(Constant.GetProfileEmployeeID + empId, string.Empty));

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    mEmployee = JsonConvert.DeserializeObject<List<EmployeeModel>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }
            return mEmployee;
        }

        public async Task<List<IjinTop10Model>> GetTOP10DataIjinJSON(string empId)
        {
            mTop10ijin = new List<IjinTop10Model>();

            var uri = new Uri(string.Format(Constant.GetTOP10DataIjin + empId, string.Empty));
            Debug.WriteLine(uri);
            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    mTop10ijin = JsonConvert.DeserializeObject<List<IjinTop10Model>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }
            return mTop10ijin;

        }

        public async Task<List<LemburTop10Model>> GetTop10DataLemburJSON(string empId)
        {
            mTop10Lembur = new List<LemburTop10Model>();

            var uri = new Uri(string.Format(Constant.GetTop10DataLemburJSON + empId, string.Empty));

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    mTop10Lembur = JsonConvert.DeserializeObject<List<LemburTop10Model>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }
            return mTop10Lembur;
        }

        public async Task<string> InsertDataEmployeeJson(string genderId, string religionId, string companyId, DateTime dateOfHire, string fullName, string nickName, string addressKtp, string addressDomisili, string city, string state, string idCard, string zipcode, DateTime birthdate, string birthplace, string maritalStatus, string phoneNumber, string mobileNumber, string email, string imageUrl, bool flag, string npwpNumber, string npwpName, string npwpAddress, string npwpFile, string npwpStatus, bool scheduleShift, bool empActive, string user, string userId, string menuId, DateTime hrDate)
        {
            var uri = new Uri(string.Format(Constant.InsertDataEmployee + genderId + "&religion_id=" + religionId + "&companyId" + companyId + "&dateOfHire=" + dateOfHire + "&fullName=" + fullName + "&nickName" + nickName + "&addressKtp" + addressKtp + "&addressDomisili" + addressDomisili + "&city" + city + "&state" + state + "&idCard" + "&idCard" + idCard + "&zipcode" + zipcode + "&bithdate" + birthdate + "&birthplace" + birthplace + "&maritalStatus" + maritalStatus + "&phoneNumber" + phoneNumber + "&mobileNumber" + mobileNumber + "&email" + email + "&imageUrl" + imageUrl + "&flag" + flag + "&npwpNumber" + npwpNumber + "&npwpName" + npwpName + "&npwpAddress" + npwpAddress + "&npwpFile" + npwpFile + "&npwpStatus" + npwpStatus + "&scheduleShift" + scheduleShift + "&empActive" + empActive + "&user" + user + "&userId" + userId + "&menuId" + menuId + "&hrDate" + hrDate, string.Empty));
            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    resultEmployee = await response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }
            return resultEmployee;
        }

        public async Task<string> InsertDataIjinJSON(string empNik, DateTime date, string startTime, string EndTime, string description, string reason, string ijinFile, string user, string menuId)
        {
            //"%dDate" -->> must be same with the web service
            var uri = new Uri(string.Format(Constant.InsertDataIjinJSON + empNik + "&dDate=" + date + "&Start_Time=" + startTime + "&End_Time=" + EndTime + "&sDescription=" + description + "&sReason=" + reason + "&sIjinFile=" + ijinFile + "&sUser=" + user + "&sMenuID=" + menuId, string.Empty));
            Debug.WriteLine(uri);

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    resultDataIjin = await response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }
            return resultDataIjin;
        }

        public async Task<string> InsertDataLemburJSON(string empNik, DateTime date, string startTime, string endTime, string lemburType, string description, string file,  string fileByte, string user, string menuId)
        {
            var uri = new Uri(string.Format(Constant.InsertDataLemburJSON + empNik + "&dDate=" + date + "&Start_Time=" + startTime + "&End_Time=" + endTime + "&sLemburType=" + lemburType + "&sDescription=" + description + "&sLemburFile=" + file + "&sLemburByte=" + fileByte + "&sUser=" + user + "&sMenuID=" + menuId, string.Empty));
            Debug.WriteLine(uri);
            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    resultDataLembur = await response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }
            return resultDataLembur;
        }

        public async Task<string> UpdateDataIjinJSON(string id, DateTime date, string startTime, string endTime, string description, string ijinFile, string user)
        {
            var uri = new Uri(string.Format(Constant.UpdateDataIjinJSON + id + "&date=" + date + "&startTime=" + startTime + "&endTime=" + endTime + "&description=" + description + "&ijinFile=" + ijinFile + "&user=" + user, string.Empty));
            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    resultUpdateIjin = await response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }
            return resultUpdateIjin;
        }

        public async Task<string> UpdateDataLemburJSON(string id, DateTime date, string startTime, string endTime, string lemburType, string description, string lembur, string user)
        {
            var uri = new Uri(string.Format(Constant.UpdateDataIjinJSON + id + "&date=" + date + "&startTime=" + startTime + "&endTime=" + endTime + "&lemburType" + lemburType + "&description=" + description + "&lembur=" + lembur + "&user=" + user, string.Empty));
            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    resultUpdateLembur = await response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }
            return resultUpdateLembur;
        }
    }
}
