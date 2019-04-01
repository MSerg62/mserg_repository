using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace BusinessRules.DataAccess
{
    class DataAccessor:DataAccessBoundary
    {
        private static Database cisDB;
        static void Init()
        {
            /// <summary>
            /// Configure the DatabaseFactory to read its configuration from the .config file
            /// </summary>
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            /// <summary>
            /// Create the default Database object from the factory.
            ///The actual concrete type is determined by the configuration settings.
            /// </summary>
            cisDB = factory.Create("cisdb");

        }
        

        public List<Patient> Patients => throw new NotImplementedException();

        public List<HCard> RegisteredHospitalCards()
        {
            List<HCard> hospitalCards = new List<HCard>() { };
           
            return hospitalCards;
        }
        public Patient getPatient(string patientId)
        {
            throw new NotImplementedException();
        }

        public void RegisterNewPatient()
        {
            throw new NotImplementedException();
        }

        public void RemovePatient(Patient patientData)
        {
            throw new NotImplementedException();
        }

        public void updatePatient(Patient patientData)
        {
            throw new NotImplementedException();
        }
    }
}
