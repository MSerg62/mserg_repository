using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRules
{
    class HCardImp:HCard
    {
        /// <summary>
        /// идентификатор истории болезни
        /// </summary>
        string HCard.Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// коллекция медицинских документов
        /// </summary>
        List<MedicalDocument> HCard.MedicalDocumentItems { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
