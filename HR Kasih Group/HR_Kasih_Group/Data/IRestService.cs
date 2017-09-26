using HR_Kasih_Group.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Kasih_Group.Data
{
    public interface IRestService
    {
        Task<string> AutentikasiUserJSON(string EmpId, string Password);
        Task<string> ApproveDataIjinJSON(string id, string user);
        Task<string> RejectDataIjinJSON(string id, string user);
        Task<string> ApproveDataLemburJSON(string id, string user);
        Task<string> RejectDataLemburJSON(string id, string user);
        Task<List<CareerModel>> GetDataCareerJSON(string empId);
        Task<List<DepartmentModel>> GetDataDepartmentByEmployeeIDJSON(string empId);
        Task<List<EducationModel>> GetDataEducationJSON(string empId);
        Task<List<EmployeeModel>> GetDataEmployeeJSON(string empId);
        Task<List<ExperienceModel>> GetDataExperienceJSON(string empId);
        Task<List<IjinModel>> GetDataIjinByHeadJSON(string headId);
        Task<List<IjinModel>> GetDataIjinByIDIjinJSON(string ijinId);
        Task<List<LemburModel>> GetDataLemburByHeadJSON(string headId);
        Task<List<LemburModel>> GetDataLemburByIDLemburJSON(string lemburID);
        Task<List<DepartmentModel>> GetDataDepartmentJSON();
        Task<List<ScheduleModel>> GetDataScheduleJSON(string empId);
        Task<List<TrainingModel>> GetDataTrainingJSON(string empId);
        Task<List<TypeIjinModel>> GetDataTypeIjinJSON();
        Task<List<TypeLemburModel>> GetDataTypeLemburJSON();
        Task<List<InboxModel>> GetInboxHeadJSON(string userId);
        Task<List<EmployeeModel>> GetProfileEmployeeIDJSON(string empId);
        Task<List<IjinTop10Model>> GetTOP10DataIjinJSON(string empId);
        Task<List<LemburTop10Model>> GetTop10DataLemburJSON(string empId);

        Task<string> InsertDataEmployeeJson(string genderId, string religionId, string companyId,
            DateTime dateOfHire, string fullName, string nickName, string addressKtp, string addressDomisili,
            string city, string state, string idCard, string zipcode, DateTime birthdate, string birthplace,
            string maritalStatus, string phoneNumber, string mobileNumber, string email, string imageUrl,
            bool flag, string npwpNumber, string npwpName, string npwpAddress, string npwpFile, string npwpStatus,
            bool scheduleShift, bool empActive, string user, string userId, string menuId, DateTime hrDate);

        Task<string> InsertDataIjinJSON(string empNik, DateTime date, string startTime, string EndTime,
            string description, string reason, string ijinFile, string user, string menuId);

        Task<string> InsertDataLemburJSON(string empNik, DateTime date, string startTime, string endTime,
            string lemburType, string description, string lembur, string fileByte, string user, string menuId);

        //Task<string> SearchDataIjinJSON(string columnName, string value, string user, int row, string companyId);
        //Task<string> SearchDataLemburJSON(string columnName, string value, string user, int row, string companyId);
        Task<string> UpdateDataIjinJSON(string id, DateTime date, string startTime, string endTime, string description, string ijinFile, string user);
        Task<string> UpdateDataLemburJSON(string id, DateTime date, string startTime, string endTime, string lemburType, string description, string lembur, string user);

        Task<string> TestConnection();
    }
}
