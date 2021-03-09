using PersonnelApp.DAL.Repositories.Abstract;
using PersonnelApp.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.DAL.Repositories.Concrete
{
    public class DepartmanRepository : Repository<Departman>, IDepartmanRepository
    {
        public DepartmanRepository(PersonelContext context):base(context) //her personelcontext aslında bır dbcontext
        {
            
        }
        public IEnumerable<Departman> GetDepartmanWithPersonel()
        {
            return PersonelContext.Departmans.Include("Personels").ToList();
        }

        public IEnumerable<Departman> GetTopDepartman(int count)
        {
            return PersonelContext.Departmans.Take(count);
        }

        public PersonelContext PersonelContext { get { return _context as PersonelContext; } } // buna sureklı ıhtıyac duyacagım ıcın bır prop eklesım ve cast ıslemı yaptım
    }
}
