using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessRules.Enum;

namespace BusinessRules.Entity
{
    public interface MedicalDocument
    {
        MedicalDocumentType DocType { get; set; }
    }
}
