using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendSimulation
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validation(Gamer gamer)
        {
            if (gamer.Birthyear == 1998 && gamer.Firstname == "Enver" && gamer.Lastname == "yıldırım" 
                && gamer.IdentityNumber == 12345)
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
