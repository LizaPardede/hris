using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Kasih_Group.Models
{
    public class IjinModel
    {
        public string ID { get; set; }
        public string Emp_NIK { get; set; }
        public string Emp_Fullname { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Start_Time { get; set; }
        public TimeSpan End_Time { get; set; }
        public int Length { get; set; }
        public string Reason { get; set; }
        public string Reason2 { get; set; }
        public string Ijin_File { get; set; }
        public string Description { get; set; }
        public object Approve_Head_Date { get; set; }
        public object Approve_HRD_Date { get; set; }
        public string AppByHead { get; set; }
        public object Type_Approve_Head { get; set; }
        public object Approve_Head_Date1 { get; set; }
        public object Approve_HRD_Date1 { get; set; }
        public string AppByHead2 { get; set; }
        public object Type_Approve_Head2 { get; set; }
        public object Approve_Head_Date2 { get; set; }
        public string Company_Name { get; set; }
    }
}
