using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessRules.Enum;

namespace BusinessRules.Entity
{
    public interface Patient
    {
        string Id { get; set; }
        string Name { get; set; }
        DateTime BirthDate { get; set; }
        string FirstName { get; set; }
        PersonIdDocument PatientIdDocument { get; set; }
        string DocumentAddress { get; set; }
        string RealAddress { get; set; }
        Gender GenderItem { get; set; }        
    }
}
