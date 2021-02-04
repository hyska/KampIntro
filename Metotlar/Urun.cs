using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class Urun
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        //Encapsulation sonradan eklenen ürün özelliği için diğer sayfalarda değişiklik yapmaya gerek duyulmaz
        public int StokAdedi { get; set; }

    }
}
