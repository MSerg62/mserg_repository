using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRules.Entity
{
    /// <summary>
    /// Электронная карта пациента
    /// </summary>
    public interface PatientEHCard
    {
        /// <summary>
        /// идентификатор электронной карты пациента
        /// </summary>
        string EHCardId { get; set; }
        /// <summary>
        /// персональные данные пациента
        /// </summary>
        Patient PatientItem { get; set; }
        /// <summary>
        /// коллекция историй болезни для случаев стационарного лечения
        /// </summary>
        List<HCard> HCardItems{ get; set; }
        /// <summary>
        /// амбулаторная карта пациента
        /// </summary>
        ACard ACardItem { get; set; }
    }
}
