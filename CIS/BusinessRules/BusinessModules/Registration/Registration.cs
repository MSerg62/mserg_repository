using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessRules.DataAccess;

namespace BusinessRules
{
    public class PatientRegistration
    {

        List<HCard> GetListHospitalCard()
        {
            List<HCard> hospitalCards = new List<HCard>(){};
            DataAccessBoundary dataAccessor = new DataAccessor();
           
            return hospitalCards;
        }
    }
    
}
