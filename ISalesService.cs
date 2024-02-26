using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gammer
{
    internal interface ISalesService
    {
        void add(Gamer gamer, Sales sales);
        void delete(Gamer gamer, Sales sales);
        void update(Gamer gamer, Sales sales);
    }
}
