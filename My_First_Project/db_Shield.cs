using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project
{
    public class db_Shield
    {
        public int Id { get; set; }  //ВАЖЛИВО!!! В БД має бути колонка просто Id без лишнього
        public string? name_shield { get; set; } // А всі назви колонок мають співпадати 

        public int figure_id { get; set; }// А всі назви колонок мають співпадати 
        public int height { get; set; }// А всі назви колонок мають співпадати 
        public int width { get; set; }// А всі назви колонок мають співпадати 

        public int size_id { get; set; }// А всі назви колонок мають співпадати  
        public db_Size Size_ { get; set; }
    }
}
