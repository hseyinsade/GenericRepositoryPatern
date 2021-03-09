using PersonnelApp.DAL;
using PersonnelApp.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.Console.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new PersonelContext());
            unitOfWork.DepartmanRepository.Add(new Departman() { Name = "BT", IsActive = true, CreatedDate = DateTime.Now });  //ram'e ekleme yapılıyor
            unitOfWork.Complete();  // burada ram'den alıp db ye aklama yapıyor ve unıtofwork siliniyor
        }
    }
}
