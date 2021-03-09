using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.Domains
{
    public class Departman:BaseEntity   //baseEntity'den miras aldık
    {
        public Departman()   //Icollectiondan dolayı null exp hhatası almamak ıcın hafızaya cıkartıyoruz
        {
            Personels = new List<Personel>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Personel> Personels { get; set; } //bir departmanda birden cok personel bulunur
    }
}
