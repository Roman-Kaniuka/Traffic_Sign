using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project
{
    public class db_Figures
    {
        public int Id { get; set; }
        public string name_figure { get; set; }
        public ICollection<db_Shields> Shield_ { get; set; }
    }
}
