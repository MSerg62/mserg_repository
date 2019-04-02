using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessRules.BusinessModules.EntitiesImp;
using BusinessRules.Entities;

namespace BusinessRules.BusinessModules.Registration
{
    public interface RegistrationOutputBoundary
    {
        string GetRegisteredPatients();
    }
}
