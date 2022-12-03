using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermartketManager.DTO
{
    internal class CategoryDTO
    {
        public int category_id { get; set; }
        public string name { get; set; }

        public CategoryDTO(int categorry_id, string name)
        {
            this.category_id = categorry_id;
            this.name = name;
        }
    }
}
