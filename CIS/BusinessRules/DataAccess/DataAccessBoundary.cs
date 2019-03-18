using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRules.DataAccess
{
    interface DataAccessBoundary
    {
        List<Patient> Patients { get; }
        void RegisterNewPatient();
        void updatePatient(Patient patientData);
        void RemovePatient(Patient patientData);
        Patient getPatient(string patientId);
    }
}
