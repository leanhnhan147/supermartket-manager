using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermartketManager.DTO
{
    internal class EmployeeDTO
    {
        public int employee_id { set; get; }
        public string name { set; get; }
        public string phone { set; get; }
        public int position_id { set; get; }

        public EmployeeDTO(int employee_id, string name, string phone, int position_id)
        {
            this.employee_id = employee_id;
            this.name = name;
            this.phone = phone;
            this.position_id = position_id;
        }
    }
}
