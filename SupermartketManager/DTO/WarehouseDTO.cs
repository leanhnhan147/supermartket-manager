using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermartketManager.DTO
{
    internal class WarehouseDTO
    {
        public int warehouse_id { get; set; }
        public string name { get; set; }
        public string address { get; set; }

        public WarehouseDTO(int warehouse_id, string name, string address)
        {
            this.warehouse_id = warehouse_id;
            this.name = name;
            this.address = address;
        }
    }
}
