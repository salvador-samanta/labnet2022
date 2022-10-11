using PracticaBF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasBF.Logic
{
    internal interface IABMLogic<T>
    {
        List<T> GetAll();
        void add(T newAdd);
        void Delete(int id);
        void Update(T update);

    }
}
