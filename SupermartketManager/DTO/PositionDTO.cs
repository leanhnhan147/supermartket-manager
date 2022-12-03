using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermartketManager.DTO
{
    internal class PositionDTO
    {
        public int position_id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }

        public PositionDTO(int position_id, string name, int salary)
        {
            this.position_id = position_id;
            this.name = name;
            this.salary = salary;
        }
    }
}
