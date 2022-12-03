using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermartketManager.DTO
{
    internal class CustomerDTO
    {
        public string customer_phone { get; set; }
        public string name { get; set; }
        public string birthday { get; set; }
        public string gender { get; set; }
        public int point { get; set; }
        public CustomerDTO(string customer_phone, string name, string birthday, string gender, int point)
        {
            this.customer_phone = customer_phone;
            this.name = name;
            this.birthday = birthday;
            this.gender = gender;
            this.point = point;
        }
    }
}
