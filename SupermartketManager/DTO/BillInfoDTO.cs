using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermartketManager.DTO
{
    internal class BillInfoDTO
    {
        public int bill_id { get; set; }
        public int product_id { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }

        public BillInfoDTO(int bill_id, int product_id, int quantity, int price)
        {
            this.bill_id = bill_id;
            this.product_id = product_id;
            this.quantity = quantity;
            this.price = price;
        }
    }
}
