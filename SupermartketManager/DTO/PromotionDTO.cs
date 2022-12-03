using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermartketManager.DTO
{
    internal class Promotion
    {
        public int promotion_id { get; set; }
        public int name { get; set; }
        public int salary { get; set; }

        public Promotion(int promotion_id, int name, int salary)
        {
            this.promotion_id = promotion_id;
            this.name = name;
            this.salary = salary;
        }
    }
}
