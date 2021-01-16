using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelenTicaretApp
{
    public class Manifatura
    {
        public string Urunler { get; set; }
        public int Fiyat { get; set; }
        public int Miktar { get; set; }
        public Manifatura()
        {

        }
        
        public Manifatura(string urunler, int fiyat, int miktar)
        {
            Urunler = urunler;
            Fiyat = fiyat;
            Miktar = miktar;
        }
    }
}
