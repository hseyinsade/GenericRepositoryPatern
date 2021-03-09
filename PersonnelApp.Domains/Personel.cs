using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.Domains
{
    public class Personel:BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int DepartmanId { get; set; }  //foreign key ıcın

        public Departman Departman { get; set; }  //navigation propertie için

    }
}
