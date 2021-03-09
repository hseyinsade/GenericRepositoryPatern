using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.DAL.Repositories.Abstract
{
    public interface IRepository<GenHal> where GenHal:class  // generic hale getirmek için yazdım ve bu bır classtır dedım
    {
        // tum entityler için ortak olan metotlar

        GenHal GetById(int id); //angi tip geldiyse onu geriye döndürecek
        IEnumerable<GenHal> GetAll();
        void Add(GenHal ek);  // bir şey döndürmeyecek ama parametre alacak
        void AddRange(IEnumerable<GenHal> eks);
        void Remove(int id);
        void RemoveRange(IEnumerable<GenHal> eks);

    }
}
