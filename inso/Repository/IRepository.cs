using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inso.Repository
{
    interface IRepository<T>
    {
        List<T> Reader();
    }
}
