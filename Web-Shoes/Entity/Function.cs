using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Shoes.Entity
{
    public class Function
    {
        public int func_Id { get; set; }
        public string func_Name { get; set; }

        public int func_ParentId { get; set; }

        public string func_Status { get; set; }

    }
}
