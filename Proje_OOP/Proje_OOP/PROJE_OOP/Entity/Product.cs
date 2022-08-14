using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROJE_OOP.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string name { get; set; }       
        public int UnityPrice { get; set; }
        public int StockAmount { get; set; }
    }
}
