using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessRules.Entities;

namespace BusinessRules.BusinessModules.EntitiesImp
{
    public class RegistrationInfoImp : RegistrationInfo
    {
        public Patient PatientData { get; set; }
    }
}
