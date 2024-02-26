using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gammer
{
    internal interface ISalesValidateService
    {
        bool Validate(Gamer gamer,Sales sales);
    }
}
