using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessRules
{
    public class EHCard<P,H,A>:PatientEHCard
    {
        public string EHCardId { get; private set; }
        public P Patient { get; set; }
        public List<H> HCard { get; set; }
        public A ACard { get; set; }
    }
}
