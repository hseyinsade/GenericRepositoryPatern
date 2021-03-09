using PersonnelApp.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.DAL.Repositories.Abstract
{
    public interface IPersonelRepository:IRepository<Personel>
    {
         IEnumerable<Personel> GetPersonelsWithDepartman();
    }
}
