using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermartketManager.DTO
{
    internal class BillDTO
    {
        public int bill_id { get; set; }
        public int employee_id { get; set; }
        public string customer_phone { get; set; }
        public string created { get; set; }
        public int discount { get; set; }
        public int total { get; set; }
        public int available { get; set; }

        public BillDTO(int bill_id, int employee_id, string customer_phone, string created, int discount, int total, int available)
        {
            this.bill_id = bill_id;
            this.employee_id = employee_id;
            this.customer_phone = customer_phone;
            this.created = created;
            this.discount = discount;
            this.total = total;
            this.available = available;
        }
    }
}
