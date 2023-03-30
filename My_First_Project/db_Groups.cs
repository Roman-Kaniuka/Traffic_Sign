using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project
{
    public class db_Groups
    {
        public int Id { get; set; }
        public string? name_group { get; set; }
        public ICollection<db_Shields> Shield_ { get; set; }
    }
}
