using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Kasih_Group.Models
{
    public class LemburModel
    {
        public string ID { get; set; }
        public string Emp_NIK { get; set; }
        public string Emp_Fullname { get; set; }
        public DateTime Date { get; set; }
        public string Start_Time { get; set; }
        public string End_Time { get; set; }
        public int Length { get; set; }
        public string Description { get; set; }
        public string Type_Approve_Head { get; set; }
        public string Approve_Head_Date { get; set; }
        public string Approve_HRD_Date { get; set; }
        public string AppByHeadName { get; set; }
        public string AppByHead { get; set; }
        public string AppByHead2 { get; set; }
        public string AppByHeadEmail { get; set; }
        public string AppByHead2Name { get; set; }
        public string Type_Approve_Head2 { get; set; }
        public string Approve_Head_Date2 { get; set; }
        public string Reason { get; set; }
        public string Lembur_File { get; set; }
    }
}
