using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelenTicaretApp
{
    public class Mobilya
    {
        public int Id { get; set; }
        public string Urunler { get; set; }
        public int Fiyat { get; set; }
        public int Miktar { get; set; }
        public Mobilya()
        {

        }

        public Mobilya(int id,string urunler, int fiyat, int miktar)
        {
            Id = id;
            Urunler = urunler;
            Fiyat = fiyat;
            Miktar = miktar;
        }
    }
}
