using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermartketManager.DTO
{
    internal class ImportDTO
    {
        public int import_id { get; set; }  
        public int company_id { get; set; }
        public int product_id { get; set; }
        public string import_date { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }
        public int available { get; set; }

        public ImportDTO(int import_id, int company_id, int product_id, string import_date, int quantity, int price)
        {
            this.import_id = import_id;
            this.company_id = company_id;
            this.product_id = product_id;
            this.import_date = import_date;
            this.quantity = quantity;
            this.price = price;
        }
    }
}
