using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRules
{
    class ACardImp:ACard
    {
        /// <summary>
        /// идентификатор амбулаторной карты пациента
        /// </summary>
       
        string ACard.Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// коллекция медицинских документов
        /// </summary>
        
        List<MedicalDocument> ACard.MedicalDocumentItems { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
