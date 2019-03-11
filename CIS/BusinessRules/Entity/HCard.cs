using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessRules.Enum;

namespace BusinessRules.Entity
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
        /// коллекция медицинских документов
        /// </summary>
        List<MedicalDocument> MedicalDocumentItems { get; set; }
    }
}
