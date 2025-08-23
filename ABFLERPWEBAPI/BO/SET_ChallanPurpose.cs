using System.ComponentModel.DataAnnotations;

namespace ABFLERPWEBAPI.BO
{
    public class SET_ChallanPurpose
    {
        private byte _ID;
        private string _PurposeName;

        public byte ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                this._ID = value;
            }
        }

        public string PurposeName
        {
            get
            {
                return this._PurposeName;
            }
            set
            {
                this._PurposeName = value;
            }
        }

        public bool IsActive { get; set; }

        public Decimal Amount { get; set; }

        public long ChallanID { get; set; }

        public byte PurposeID { get; set; }
    }
}
