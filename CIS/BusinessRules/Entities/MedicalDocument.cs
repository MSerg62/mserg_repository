using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessRules
{
    public interface MedicalDocument
    {
        MedicalDocumentType DocType { get; set; }
    }
}
