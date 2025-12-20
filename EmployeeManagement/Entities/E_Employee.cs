using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Entities
{
    public class E_Employee
    {
        public int id_employee { get; set; }
        public string employee_name { get; set; }
        public string employee_address { get; set; }
        public DateTime employee_bithdate { get; set; }
        public string employee_phone_number { get; set; }
        public decimal employe_salary { get; set; }
        public int id_department { get; set; }
        public int id_position { get; set; }
    }
}
