using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Kasih_Group.Models
{
    public class LemburTop10Model
    {
        public string ID { get; set; }
        public string Emp_NIK { get; set; }
        public string Emp_Fullname { get; set; }
        public DateTime Date { get; set; }
        public string Start_Time { get; set; }
        public string End_Time { get; set; }
        public int Length { get; set; }
        public string Lembur_Type { get; set; }
        public string Reason { get; set; }
        public string Description { get; set; }
        public DateTime Approve_Head_Date { get; set; }
        public object Approve_HRD_Date { get; set; }
        public string AppByHead { get; set; }
        public string Type_Approve_Head { get; set; }
        public DateTime Approve_Head_Date1 { get; set; }
        public object Approve_HRD_Date1 { get; set; }
        public string AppByHead2 { get; set; }
        public string Type_Approve_Head2 { get; set; }
        public DateTime? Approve_Head_Date2 { get; set; }
        public bool Done_Head { get; set; }
        public bool Done_HRD { get; set; }
        public bool Done_Head2 { get; set; }
        public string Company_Name { get; set; }
        public object Type_Approve_HRD { get; set; }
        public object AppByHRD { get; set; }
        public string Lembur_File { get; set; }
    }
}
