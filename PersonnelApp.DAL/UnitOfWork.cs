using PersonnelApp.DAL.Repositories.Abstract;
using PersonnelApp.DAL.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.DAL
{
    public class UnitOfWork:IUnitOfWork
    {
        private PersonelContext _personelContext;
        public UnitOfWork(PersonelContext context)
        {
            _personelContext = context;   //personelcontext fieldı dısarıdan verılen contexte eşit
            // burası interface ve atama işlemleri yapıyoruz
            DepartmanRepository = new DepartmanRepository(_personelContext);  
            PersonelRepository = new PersonelRepository(_personelContext);
        }

        public IDepartmanRepository DepartmanRepository { get; private set; }

        public IPersonelRepository PersonelRepository { get; private set; }

        public int Complete()
        {
           return _personelContext.SaveChanges();
        }

        public void Dispose()
        {
             _personelContext.Dispose();
        }
    }
}
