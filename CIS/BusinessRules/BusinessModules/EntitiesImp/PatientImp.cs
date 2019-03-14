using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRules.BusinessModules.EntitiesImp
{
    class PatientImp : Patient
    {
        public string Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PatientId { get; set; }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime BirthDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public PersonIdDocument PatientIdDocument { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string DocumentAddress { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string RealAddress { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Gender GenderItem { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
