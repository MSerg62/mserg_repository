using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRules.Entity
{
    public interface Patient
    {
        string Id { get; set; }
        string Name { get; set; }
        string FirstName { get; set; }
        string DocumentAddress { get; set; }
        string RealAddress { get; set; }
        
    }
}
