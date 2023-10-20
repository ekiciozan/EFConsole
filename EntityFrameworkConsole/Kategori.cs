using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkConsole
{
    public class Kategori
    {
        //varsayılan olarak otomatik olarak alır, değer göndermek gerekmez.PrimaryKey oldu Id dediğimiz için.
        public int Id { get; set; }
        public string KategoriAdi { get; set; }
    }
}
