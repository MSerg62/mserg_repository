using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessRules
{
    /// <summary>
    /// история болезни для случая госпитализации
    /// </summary>
    public interface HCard
    {
        /// <summary>
        /// идентификатор истории болезни
        /// </summary>
        string Id { get; set; }
        /// <summary>
        /// данные пациента
        /// </summary>
        Patient PatientData { get; set; }
        /// <summary>
        /// коллекция медицинских документов
        /// </summary>
        List<MedicalDocument> MedicalDocumentItems { get; set; }
    }
}
