using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Utils;
using BusinessRules.Entities;
using BusinessRules.BusinessModules.EntitiesImp;

namespace BusinessRules.DataAccess
{
    public class DataAccessor:DataAccessBoundary
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
            cisDB = factory.CreateDefault();

        }
        

        public List<Patient> Patients => throw new NotImplementedException();

        public List<HCard> GetRegisteredHospitalCards()
        {
            List<HCard> hospitalCards = new List<HCard>() { };
            if (cisDB == null) Init();
            using (System.Data.IDataReader reader = cisDB.ExecuteReader(CommandType.Text, "GetRegisteredHospitalCards"))
            {
                FillHospitalCards(ref hospitalCards,reader);
            }
            return hospitalCards;
        }
        public List<RegistrationInfo> GetRegisteredPatients()
        {
            List<RegistrationInfo> registeredPatients = new List<RegistrationInfo>() {};
            if (cisDB == null) Init();
            using (System.Data.IDataReader reader = cisDB.ExecuteReader(CommandType.Text, "GetRegisteredHospitalCards"))
            {
                FillRegistrationInfoList(ref registeredPatients, reader);
            }
            return registeredPatients;
        }

        private void FillHospitalCards(ref List<HCard> hospitalCards,IDataReader reader)
        {
            HCard card = new HCardImp();
            while (reader.Read())
            {
                Patient patient = new PatientImp();
                for (int i = 0; i < reader.FieldCount; i++)
                {                 
                    patient.Name = reader["Name"].ToString();
                    patient.FirstName=reader["FirstName"]!=null?reader["FirstName"].ToString():String.Empty;
                    patient.BirthDate = UnsafeTypeCust.DbDateToDateTimeCust(reader["BirthDate"]);
                    patient.DocumentAddress = String.Format("{0},{1},ул.{2},д.{3},кв.{4}",
                                                                          reader["Post"].ToString(), 
                                                                          reader["City"].ToString(), 
                                                                          reader["Street"].ToString(),
                                                                          reader["Hous"].ToString(),
                                                                          reader["Flat"].ToString());                  
                }
                patient.BirthDateString = String.Format("{0}.{1}.{2}",patient.BirthDate.Day, patient.BirthDate.Month, patient.BirthDate.Year);
                card.PatientData = patient;
                hospitalCards.Add(card);
            }         

        }
        private void FillRegistrationInfoList(ref List<RegistrationInfo> registeredPatients, IDataReader reader)
        {
            RegistrationInfo regInfo = new RegistrationInfoImp();
            while (reader.Read())
            {
                Patient patient = new PatientImp();
                    patient.Name = reader["Name"].ToString();
                    patient.FirstName = reader["FirstName"] != null ? reader["FirstName"].ToString() : String.Empty;
                    patient.BirthDate = UnsafeTypeCust.DbDateToDateTimeCust(reader["BirthDate"]);
                    patient.DocumentAddress = String.Format("{0},{1},ул.{2},д.{3},кв.{4}",
                                                                          reader["Post"].ToString(),
                                                                          reader["City"].ToString(),
                                                                          reader["Street"].ToString(),
                                                                          reader["Hous"].ToString(),
                                                                          reader["Flat"].ToString());
                patient.BirthDateString = String.Format("{0}.{1}.{2}", patient.BirthDate.Day, patient.BirthDate.Month, patient.BirthDate.Year);
                patient.BirthDateMsec = UnsafeTypeCust.ToJavaScriptMilliseconds(patient.BirthDate);
                regInfo.PatientData = patient;
                registeredPatients.Add(regInfo);
            }

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
