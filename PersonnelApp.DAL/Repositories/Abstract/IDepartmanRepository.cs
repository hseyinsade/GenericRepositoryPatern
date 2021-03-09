using PersonnelApp.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.DAL.Repositories.Abstract
{
     public interface IDepartmanRepository:IRepository<Departman>
    {
        IEnumerable<Departman> GetTopDepartman(int count);
        IEnumerable<Departman> GetDepartmanWithPersonel();
    }
}
