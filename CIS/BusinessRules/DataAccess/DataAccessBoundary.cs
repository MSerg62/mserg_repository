using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessRules.Entities;

namespace BusinessRules.DataAccess
{
    public interface DataAccessBoundary
    {
        List<Patient> Patients { get; }
        List<HCard> GetRegisteredHospitalCards();
        List<RegistrationInfo> GetRegisteredPatients();
        void RegisterNewPatient();
        void updatePatient(Patient patientData);
        void RemovePatient(Patient patientData);
        Patient getPatient(string patientId);
    }
}
