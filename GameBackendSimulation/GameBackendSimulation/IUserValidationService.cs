using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendSimulation
{
    interface IUserValidationService
    {
        bool Validation(Gamer gamer);
    }
}
