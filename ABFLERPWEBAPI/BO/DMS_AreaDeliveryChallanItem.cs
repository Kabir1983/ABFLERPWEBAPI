using System.ComponentModel.DataAnnotations;

namespace ABFLERPWEBAPI.BO
{
    public class DMS_AreaDeliveryChallanItem
    {
        private long _ChallanItemID;
        private long _ChallanID;
        private long _ASID;
        private long _ReturnASID;
        private short _ProductID;
        private long _Qty;
        private long? _ReturnQty;
        private int _InsertUserID;
        private DateTime _LastUpdate;
        private Decimal _TP;
        private int _SampleQty;
        private int _SampleReturnQty;

        public long ChallanItemID
        {
            get
            {
                return this._ChallanItemID;
            }
            set
            {
                this._ChallanItemID = value;
            }
        }

        public long ChallanID
        {
            get
            {
                return this._ChallanID;
            }
            set
            {
                this._ChallanID = value;
            }
        }

        public long ASID
        {
            get
            {
                return this._ASID;
            }
            set
            {
                this._ASID = value;
            }
        }

        public long ReturnASID
        {
            get
            {
                return this._ReturnASID;
            }
            set
            {
                this._ReturnASID = value;
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

        public long? ReturnQty
        {
            get
            {
                return this._ReturnQty;
            }
            set
            {
                this._ReturnQty = value;
            }
        }

        public int InsertUserID
        {
            get
            {
                return this._InsertUserID;
            }
            set
            {
                this._InsertUserID = value;
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

        public int SampleQty
        {
            get
            {
                return this._SampleQty;
            }
            set
            {
                this._SampleQty = value;
            }
        }

        public int SampleReturnQty
        {
            get
            {
                return this._SampleReturnQty;
            }
            set
            {
                this._SampleReturnQty = value;
            }
        }

        public long ChallanQty { get; set; }

        public string ProductName { get; set; }

        public long? TotalOut { get; set; }

        public Decimal ProductPrice { get; set; }

        public Decimal ChallanAmount { get; set; }
    }
}
