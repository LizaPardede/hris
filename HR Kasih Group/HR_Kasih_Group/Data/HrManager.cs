using HR_Kasih_Group.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Kasih_Group.Data
{
    public class HrManager
    {
        public IRestService restService;

        public HrManager(IRestService service)
        {
            restService = service;
        }

        public Task<string> TestConnection()
        {
            return restService.TestConnection();
        }



        public Task<string> AutentikasiUserJSON(string username, string password)
        {
            return restService.AutentikasiUserJSON(username, password);
        }

        public Task<string> ApproveDataIjinJSON(string id, string user)
        {
            return restService.ApproveDataIjinJSON(id, user);
        }

        public Task<string> RejectDataIjinJSON(string id, string user)
        {
            return restService.RejectDataIjinJSON(id, user);
        }

        public Task<string> ApproveDataLemburJSON(string id, string user)
        {
            return restService.ApproveDataLemburJSON(id, user);
        }

        public Task<string> RejectDataLemburJSON(string id, string user)
        {
            return restService.RejectDataLemburJSON(id, user);
        }

        public Task<List<CareerModel>> GetDataCareerJSON(string empId)
        {
            return restService.GetDataCareerJSON(empId);
        }

        public Task<List<DepartmentModel>> GetDataDepartmentByEmployeeIDJSON(string empId)
        {
            return restService.GetDataDepartmentByEmployeeIDJSON(empId);
        }

        public Task<List<EducationModel>> GetDataEducationJSON(string empId)
        {
            return restService.GetDataEducationJSON(empId);
        }

        public Task<List<EmployeeModel>> GetDataEmployeeJSON(string empId)
        {
            return restService.GetDataEmployeeJSON(empId);
        }

        public Task<List<ExperienceModel>> GetDataExperienceJSON(string empId)
        {
            return restService.GetDataExperienceJSON(empId);
        }

        public Task<List<IjinModel>> GetDataIjinByHeadJSON(string headId)
        {

            return restService.GetDataIjinByHeadJSON(headId);
        }

        public Task<List<IjinModel>> GetDataIjinByIDIjinJSON(string ijinId)
        {
            return restService.GetDataIjinByIDIjinJSON(ijinId);
        }

        public Task<List<LemburModel>> GetDataLemburByHeadJSON(string headId)
        {
            return restService.GetDataLemburByHeadJSON(headId);
        }

        public Task<List<DepartmentModel>> GetDataDepartmentJSON()
        {
            return restService.GetDataDepartmentJSON();
        }

        public Task<List<LemburModel>> GetDataLemburByIDLemburJSON(string lemburID)
        {
            return restService.GetDataLemburByIDLemburJSON(lemburID);
        }

        public Task<List<ScheduleModel>> GetDataScheduleJSON(string empId)
        {
            return restService.GetDataScheduleJSON(empId);
        }

        public Task<List<TrainingModel>> GetDataTrainingJSON(string empId)
        {
            return restService.GetDataTrainingJSON(empId);
        }

        public Task<List<TypeIjinModel>> GetDataTypeIjinJSON()
        {
            return restService.GetDataTypeIjinJSON();
        }

        public Task<List<TypeLemburModel>> GetDataTypeLemburJSON()
        {
            return restService.GetDataTypeLemburJSON();
        }

        public Task<List<InboxModel>> GetInboxHeadJSON(string userId)
        {
            return restService.GetInboxHeadJSON(userId);
        }

        public Task<List<EmployeeModel>> GetProfileEmployeeIDJSON(string empId)
        {
            return restService.GetProfileEmployeeIDJSON(empId);
        }

        public Task<List<IjinTop10Model>> GetTOP10DataIjinJSON(string empId)
        {
            return restService.GetTOP10DataIjinJSON(empId);
        }

        public Task<List<LemburTop10Model>> GetTop10DataLemburJSON(string empId)
        {
            return restService.GetTop10DataLemburJSON(empId);
        }

        public Task<string> InsertDataEmployeeJson(string genderId, string religionId, string companyId,
            DateTime dateOfHire, string fullName, string nickName, string adressKtp, string adressDomisili,
            string city, string state, string idCard, string zipcode, DateTime birthdate, string birthplace,
            string maritalStatus, string phoneNumber, string mobileNumber, string email, string imageUrl,
            bool flag, string npwpNumber, string npwpName, string npwpAddress, string npwpFile, string npwpStatus,
            bool scheduleShift, bool empActive, string user, string userId, string menuId, DateTime hrDate)
        {
            return restService.InsertDataEmployeeJson(genderId, religionId, companyId, dateOfHire, fullName, nickName,
                adressKtp, adressDomisili, city, state, idCard, zipcode, birthdate, birthplace, maritalStatus, phoneNumber,
                mobileNumber, email, imageUrl, flag, npwpNumber, npwpName, npwpAddress, npwpFile, npwpStatus, scheduleShift,
                empActive, user, userId, menuId, hrDate);
        }

        public Task<string> InsertDataIjinJSON(string empNik, DateTime date, string startTime, string EndTime,
            string description, string reason, string ijinFile, string user, string menuId)
        {
            return restService.InsertDataIjinJSON(empNik, date, startTime, EndTime, description,reason, ijinFile, user, menuId);
        }

        public Task<string> InsertDataLemburJSON(string empNik, DateTime date, string startTime, string endTime,
            string lemburType, string description, string lembur, string fileByte, string user, string menuId)
        {
            return restService.InsertDataLemburJSON(empNik, date, startTime, endTime, lemburType, description, lembur, fileByte, user, menuId);
        }

        //public Task<string> SearchDataIjinJSON(string columnName, string value, string user, int row, string companyId)
        //{
        //    return restService.SearchDataIjinJSON(columnName, value, user, row, companyId);
        //}

        //public Task<string> SearchDataLemburJSON(string columnName, string value, string user, int row, string companyId)
        //{
        //    return restService.SearchDataLemburJSON(columnName, value, user, row, companyId);
        //}

        Task<string> UpdateDataIjinJSON(string id, DateTime date, string startTime, string endTime, string description, string ijinFile, string user)
        {
            return restService.UpdateDataIjinJSON(id, date, startTime, endTime, description, ijinFile, user);
        }

        Task<string> UpdateDataLemburJSON(string id, DateTime date, string startTime, string endTime, string lemburType, string description, string lembur, string user)
        {
            return restService.UpdateDataLemburJSON(id, date, startTime, endTime, lemburType, description, lembur, user);
        }
    }
}
