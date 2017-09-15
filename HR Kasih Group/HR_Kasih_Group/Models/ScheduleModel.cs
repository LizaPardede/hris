using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Kasih_Group.Models
{
    public class ScheduleModel
    {
        public string T_Schedule_ID { get; set; }
        public string Emp_NIK { get; set; }
        public string ID_Shift { get; set; }
        public DateTime Schedule_Date { get; set; }
        public DateTime Insert_Date { get; set; }
        public string Insert_User { get; set; }
        public DateTime Update_Date { get; set; }
        public string Update_User { get; set; }
        public bool Status_Batching { get; set; }
        public DateTime Batching_Date { get; set; }
        public string Emp_Fullname { get; set; }
        public string Name_Shift { get; set; }
        public string Schedule { get; set; }
    }
}
