using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkConsole
{
    class Program
    {
        static void Main(string[] args)
        {



            Kategori k = new Kategori();
            //k.Id = 1;
            k.KategoriAdi = "Bilgisayar";

            UrunContext db = new UrunContext();
            db.Kategoriler.Add(k);
            db.SaveChanges();
            Console.WriteLine("DB'ye kayit edildi.");
            Console.ReadLine();



            //List<Kategori> kategoriler = new List<Kategori>()
            //{
            //    new Kategori(){Id=1 , KategoriAdi = "Telefon"},
            //    new Kategori(){Id=2 , KategoriAdi = "Bilgisayar"},
            //    new Kategori(){Id=3 , KategoriAdi = "Tablet"}
            //};
            //kategoriler.Add(k);
        }
    }
}
