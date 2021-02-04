using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; }
        //program okunurluğunu arttırmak için 
        //foreign keyler primary key nin altına yazılır
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; }
    }
}
