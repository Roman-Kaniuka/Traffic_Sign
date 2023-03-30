using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project
{
    public class db_Figure
    {
        public int Id { get; set; }
        public string name_figure { get; set; }
        public ICollection<db_Shield> Shield_ { get; set; }
    }
}
