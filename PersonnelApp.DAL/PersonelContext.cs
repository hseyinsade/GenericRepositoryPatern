using PersonnelApp.Domains;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.DAL
{
    public class PersonelContext:DbContext
    {
        public PersonelContext():base("PersonelContext")   // hangi veritabanına yazacagını bılmıyor dıye connetion stringini belirliyoruz.
        {

        }
        public DbSet<Departman> Departmans { get; set; }
        public DbSet<Personel> Personels { get; set; }
    }
}
