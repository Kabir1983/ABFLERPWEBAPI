using System.ComponentModel.DataAnnotations;

namespace ABFLERPWEBAPI.BO
{
    public class DMS_IncentiveDetail
    {
        private long _ID;
        private long _DMID;
        private short _ProductID;
        private long _Quantity;
        private Decimal _TP;
        private DateTime _LastUpdate;

        public long ID
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

        public long DMID
        {
            get
            {
                return this._DMID;
            }
            set
            {
                this._DMID = value;
            }
        }

        public short ProductID
        {
            get
            {
                return this._ProductID;
            }
            set
            {
                this._ProductID = value;
            }
        }

        public long Quantity
        {
            get
            {
                return this._Quantity;
            }
            set
            {
                this._Quantity = value;
            }
        }

        public Decimal TP
        {
            get
            {
                return this._TP;
            }
            set
            {
                this._TP = value;
            }
        }

        public DateTime LastUpdate
        {
            get
            {
                return this._LastUpdate;
            }
            set
            {
                this._LastUpdate = value;
            }
        }

        public long ASID { get; set; }
    }
}
