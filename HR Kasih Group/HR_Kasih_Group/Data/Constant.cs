using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Kasih_Group.Data
{
    public class Constant
    {
        public static bool IsDev = true;
        public static string HRRestUrl = "http://10.160.1.37/HRAndroidService/WebServiceHRApp.asmx";

        public static string ApproveDataIjin = HRRestUrl + "/ApproveDataIjinJSON?sID=";
        public static string ApproveDataLembur = HRRestUrl + "/ApproveDataLemburJSON?sID=";
        public static string AutentikasiUserJSON = HRRestUrl + "/AutentikasiUserJSON?sUsername=";
        public static string GetDataCareer = HRRestUrl + "/GetDataCareerJSON?sIDEmp=";
        public static string GetDataDepartmentById = HRRestUrl + "/GetDataDepartmentByEmployeeIDJSON?EmpID=";
        public static string GetDataDeparment = HRRestUrl + "/GetDataDepartmentJSON";
        public static string GetDataEducation = HRRestUrl + "/GetDataEducationJSON?sIDEmp=";
        public static string GetDataEmployee = HRRestUrl + "/GetDataEmployeeJSON";
        public static string GetDataExperience = HRRestUrl + "/GetDataExperienceJSON?sIDEmp=";
        public static string GetDataIjinByHead = HRRestUrl + "/GetDataIjinByHeadJSON?sHead=";
        public static string GetDataIjinByIDIjin = HRRestUrl + "/GetDataIjinByIDIjinJSON?sIDIjin=";
        public static string GetDataLemburByHead = HRRestUrl + "/GetDataLemburByHeadJSON?sHead=";
        public static string GetDataLemburByIDLembur = HRRestUrl + "/GetDataLemburByIDLemburJSON?sIDLembur=";
        public static string GetDataSchedule = HRRestUrl + "/GetDataScheduleJSON?sIDEmp=";
        public static string GetDataTraining = HRRestUrl + "/GetDataTrainingJSON?sIDEmp=";
        public static string GetDataTypeIjin = HRRestUrl + "/GetDataTypeIjinJSON";
        public static string GetDataTypeLembur = HRRestUrl + "/GetDataTypeLemburJSON";
        public static string GetInboxHeadJSON = HRRestUrl + "/GetInboxHeadJSON?sUser=";
        public static string GetProfileEmployeeID = HRRestUrl + "/GetProfileEmployeeIDJSON?EmpID=";
        public static string GetTOP10DataIjin = HRRestUrl + "/GetTOP10DataIjinJSON?sIDEmp=";
        public static string GetTop10DataLemburJSON = HRRestUrl + "/GetTop10DataLemburJSON?sIDEmp=";
        public static string InsertDataEmployee = HRRestUrl + "/InsertDataEmployeeJson?sGender_ID:=";
        public static string InsertDataIjinJSON = HRRestUrl + "/InsertDataIjinJSON?sEmpNIK=";
        public static string InsertDataLemburJSON = HRRestUrl + "/InsertDataLemburJSON?sEmpNIK=";
        public static string RejectDataIjinJSON = HRRestUrl + "/RejectDataIjinJSON?sID=";
        public static string RejectDataLemburJSON = HRRestUrl + "/RejectDataLemburJSON?sID=";
        public static string SearchDataIjinJSON = HRRestUrl + "/SearchDataIjinJSON?sColumnName=";
        public static string SearchDataLemburJSON = HRRestUrl + "/SearchDataLemburJSON?sColumnName=";
        public static string UpdateDataIjinJSON = HRRestUrl + "/UpdateDataIjinJSON?sID=";
        public static string UpdateDataLemburJSON = HRRestUrl + "/UpdateDataLemburJSON?sID=";
    }
}
