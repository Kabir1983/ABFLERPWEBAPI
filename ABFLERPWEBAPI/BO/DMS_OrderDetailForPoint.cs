using System.ComponentModel.DataAnnotations;

namespace ABFLERPWEBAPI.BO
{
    public class DMS_OrderDetailForPoint
    {
        private long _OrderDetailID;
        private long _OrderID;
        private short _ProductID;
        private int _Qty;
        private Decimal _TP;
        private Decimal _GrossTotal;
        private DateTime _LastUpdate;

        public long OrderDetailID
        {
            get
            {
                return this._OrderDetailID;
            }
            set
            {
                this._OrderDetailID = value;
            }
        }

        public long OrderID
        {
            get
            {
                return this._OrderID;
            }
            set
            {
                this._OrderID = value;
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

        public int Qty
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

        public Decimal GrossTotal
        {
            get
            {
                return this._GrossTotal;
            }
            set
            {
                this._GrossTotal = value;
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

        public int OutletID { get; set; }

        public int? SampleQty { get; set; }

        public int? BlankPacket { get; set; }

        public int? FQty { get; set; }

        public string SamplePerson { get; set; }

        public string ProductName { get; set; }

        public int? DamageQty { get; set; }

        public long? ReturnQty { get; set; }

        public long? TotalQty { get; set; }

        public Decimal? IncentiveQty { get; set; }
    }
}
