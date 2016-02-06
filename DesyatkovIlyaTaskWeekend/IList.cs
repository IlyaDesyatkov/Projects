using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesyatkovIlyaTaskWeekend
{
    public interface IList <T>
    {
        void Append(T cellData);
        void Insert(int index, T newCell);
        void Delete(int index);
    }
}
