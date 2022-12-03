using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermartketManager.DTO
{
    internal class CompanyDTO
    {
        public int company_id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }

        public CompanyDTO(int company_id, string name, string address, string phone)
        {
            this.company_id = company_id;
            this.name = name;
            this.address = address;
            this.phone = phone;
        }
    }
}
