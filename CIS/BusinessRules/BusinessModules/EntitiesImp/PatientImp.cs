using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRules
{
    public class PatientImp : Patient
    {
        public string Id { get; set; }
        public string PatientId { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public long BirthDateMsec { get; set; }
        public string BirthDateString { get; set; }
        public string FirstName { get; set; }
        public PersonIdDocument PatientIdDocument { get; set; }
        public string DocumentAddress { get; set; }
        public string RealAddress { get; set; }
        public Gender GenderItem { get; set; }
    }
}
