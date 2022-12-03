using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermartketManager.DTO
{
    internal class AccountDTO
    {
        public string username { get; set; }
        public string password { get; set; }
        public int employee_id { get; set; }

        public AccountDTO(string username, string password, int employee_id)
        {
            this.username = username;
            this.password = password;
            this.employee_id = employee_id;
        }

        public object[] ToArray()
        {
            return new object[] { username, password, employee_id };
        }
    }
}
