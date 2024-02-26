using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gammer
{
    internal class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.BirthYear == 2001 && gamer.FirstName == "Serkan" && gamer.LastName=="Yıldırım" && gamer.IdentityNumber == 12345)
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
