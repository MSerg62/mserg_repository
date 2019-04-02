using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessRules;
using BusinessRules.Entities;
using BusinessRules.DataAccess;

namespace BusinessRules.BusinessModules.Registration
{
    public class RegistrationOutputData: RegistrationOutputBoundary
    {
        public List<RegistrationInfo> GetRegisteredPatients()
        {
             DataAccessBoundary dataAccessBoundary = new DataAccessor();
             List<HCard> hospitalCards = dataAccessBoundary.GetRegisteredHospitalCards();

        }

    }
}
