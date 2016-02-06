using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesyatkovIlyaTaskWeekend
{
    public interface IQueue<T>
    {
        void Push(T newCellData);
        T Pop();
    }
}
