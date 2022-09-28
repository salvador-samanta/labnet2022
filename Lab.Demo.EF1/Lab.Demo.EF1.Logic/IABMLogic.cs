using Lab.Demo.EF1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF1.Logic
{
    interface IABMLogic <T>
    {
        List<T> GetAll();
        void add(T newAdd);
        void Delete(int id);
        void Update(T update);
    }
}
