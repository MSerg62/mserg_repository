using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessRules;
using BusinessRules.Entities;
using BusinessRules.DataAccess;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace BusinessRules.BusinessModules.Registration
{
    public class RegistrationOutputData: RegistrationOutputBoundary
    {
        public string GetRegisteredPatients()
        {
             DataAccessBoundary dataAccessBoundary = new DataAccessor();
             List<RegistrationInfo> registeredPatients = dataAccessBoundary.GetRegisteredPatients();
           // var serializer = new JavaScriptSerializer();
          //  var serializedResult = serializer.Serialize(registeredPatients);
            string json = JsonConvert.SerializeObject(registeredPatients, Formatting.Indented);
            return json;// serializedResult.ToString();

        }

    }
}
