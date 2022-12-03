using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermartketManager.DTO
{
    internal class ProductDTO
    {
        public int product_id { get; set; }
        public string name { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }
        public string mfg_date { get; set; }
        public string exp_date { get; set; }
        public int available { get; set; }
        public int category_id { get; set; }
        public int warehouse_id { get; set; }
        public int promotion_id { get; set; }
        public ProductDTO(int product_id, string name, int quantity, int price, string mfg_date, string exp_date, int category_id, int warehouse_id)
        {
            this.product_id = product_id;
            this.name = name;
            this.quantity = quantity;
            this.price = price;
            this.mfg_date = mfg_date;
            this.exp_date = exp_date;
            this.category_id = category_id;
            this.warehouse_id = warehouse_id;
        }
    }
}
