using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project
{
    public class db_Sizes
    {
        public int Id { get; set; }    //ВАЖЛИВО!!! В БД має бути колонка просто Id без лишнього
        public string? name_size { get; set; }  // А всі назви колонок мають співпадати 
        public ICollection<db_Shields> Shield_ { get; set; }
    }
}
