using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRules
{
    public class PatientImp : Patient
    {
        public string Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PatientId { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string FirstName { get; set; }
        public PersonIdDocument PatientIdDocument { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string DocumentAddress { get; set; }
        public string RealAddress { get; set; }
        public Gender GenderItem { get; set; }
    }
}
