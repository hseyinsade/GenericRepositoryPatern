using PersonnelApp.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.DAL
{
    public interface IUnitOfWork:IDisposable  // bu mıras ıle dıyoruz kı ıslemın bıtınce kendını sıl
    {
         IDepartmanRepository DepartmanRepository { get; }
         IPersonelRepository PersonelRepository { get; }

        int Complete();
    }
}
