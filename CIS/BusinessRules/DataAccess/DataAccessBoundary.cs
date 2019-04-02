using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRules.DataAccess
{
    public interface DataAccessBoundary
    {
        List<Patient> Patients { get; }
        List<HCard> GetRegisteredHospitalCards();
        void RegisterNewPatient();
        void updatePatient(Patient patientData);
        void RemovePatient(Patient patientData);
        Patient getPatient(string patientId);
    }
}
