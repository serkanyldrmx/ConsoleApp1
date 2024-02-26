using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gammer
{
    internal class SalesValidateManager:ISalesValidateService
    {
        public bool Validate(Gamer gamer, Sales sales)
        {
            if (sales.SalesName =="GTA" || sales.SalesName == "Valorant" || sales.SalesName == "LOL" || sales.SalesName == "CS")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
