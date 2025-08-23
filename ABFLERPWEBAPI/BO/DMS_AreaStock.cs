using System.ComponentModel.DataAnnotations;

namespace ABFLERPWEBAPI.BO
{
    public class DMS_AreaStock
    {
        private long _FSID;
        private int _AreaID;
        private short _ProductID;
        private long _Qty;
        private Decimal _TP;
        private byte _StockType;
        private DateTime _StockDate;

        public long ASID
        {
            get
            {
                return this._FSID;
            }
            set
            {
                this._FSID = value;
            }
        }

        public int AreaID
        {
            get
            {
                return this._AreaID;
            }
            set
            {
                this._AreaID = value;
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

        public long Qty
        {
            get
            {
                return this._Qty;
            }
            set
            {
                this._Qty = value;
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

        public byte StockType
        {
            get
            {
                return this._StockType;
            }
            set
            {
                this._StockType = value;
            }
        }

        public DateTime StockDate
        {
            get
            {
                return this._StockDate;
            }
            set
            {
                this._StockDate = value;
            }
        }

        public long Balance { get; set; }

        public DateTime LastUpdate { get; set; }

        public DateTime TransactionDate { get; set; }
    }
}
