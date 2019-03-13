using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRules
{
    /// <summary>
    /// амбулаторная карта пациента
    /// </summary>
     public interface ACard
    {
        /// <summary>
        /// идентификатор амбулаторной карты пациента
        /// </summary>
        string Id { get; set; }
        /// <summary>
        /// коллекция медицинских документов
        /// </summary>
        List<MedicalDocument> MedicalDocumentItems { get; set; }
    }
}
