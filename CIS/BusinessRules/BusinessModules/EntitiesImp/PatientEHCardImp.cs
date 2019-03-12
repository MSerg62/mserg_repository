using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRules
{
    class PatientEHCardImp:PatientEHCard
    {
        /// идентификатор электронной карты пациента
        /// </summary>
        
       public string EHCardId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// персональные данные пациента
        /// </summary>
        public Patient PatientItem { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// коллекция историй болезни для случаев стационарного лечения
        /// </summary>
        public List<HCard> HCardItems { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// амбулаторная карта пациента
        /// </summary>
        public ACard ACardItem { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// добавить амбулаторную карту
        /// </summary>
        /// <returns></returns>
        bool AddACard() {

            try{
                if (this.ACardItem == null) this.ACardItem = new ACardImp();
                return true;
            }
            catch(Exception){
                return false;
            }
            
        }

        bool PatientEHCard.AddACard()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// добавить историю болезни для стационарного случая
        /// </summary>
        /// <returns></returns>
        bool AddHCard() {

            try
            {
                this.HCardItems.Add(new HCardImp());
                return true;
            }
            catch (Exception)
            {
                return false;               
            }

        }

        bool PatientEHCard.AddHCard()
        {
            throw new NotImplementedException();
        }
    }
}
