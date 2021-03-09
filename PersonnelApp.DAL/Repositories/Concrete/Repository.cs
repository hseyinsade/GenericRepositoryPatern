using PersonnelApp.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.DAL.Repositories.Concrete
{
    public class Repository<GenHal> : IRepository<GenHal> where GenHal : class //generik olarak tanımlıyorum yanı ne gelırse onu gonderecek
    {
        protected DbContext _context;    //Repository classını miras olarak kullanıcam ve dbcontext tıpınde fıeld tanımladım
        private DbSet<GenHal> _dbset;
        public Repository(DbContext context)   // repository classını kullanmak ısteyen artık buna parametre olarak dbcontxt nesnesını vermek zorunda
        {
            _context = context;
            _dbset = _context.Set<GenHal>();
        }
        public void Add(GenHal ek)
        {
            //_context.Departmans
            // _context.Set<GenHal>().Add(ek);
            _dbset.Add(ek);
        }

        public void AddRange(IEnumerable<GenHal> eks)
        {
            //_context.Set<GenHal>().AddRange(eks);
            _dbset.AddRange(eks);
        }

        public IEnumerable<GenHal> GetAll()
        {
            return _dbset.ToList();
        }

        public GenHal GetById(int id)
        {
            return _dbset.Find(id);
        }

        public void Remove(int id)
        {
            _dbset.Remove(GetById(id));
        }

        public void RemoveRange(IEnumerable<GenHal> eks)
        {
            _dbset.RemoveRange(eks);
        }
    }
}
