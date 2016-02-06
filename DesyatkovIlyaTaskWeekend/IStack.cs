using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesyatkovIlyaTaskWeekend
{
    public interface IStack<T>
    {
        void PushS(T newCellData);
        T PopS();
    }
}
