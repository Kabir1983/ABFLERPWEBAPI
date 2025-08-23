using System.ComponentModel.DataAnnotations;

namespace ABFLERPWEBAPI.BO
{
    public class DMS_SampleItem
    {
        private long _SampleItemID;
        private long _SampleID;
        private short _ProductID;
        private int _Qty;
        private DateTime _LastUpdate;

        public long SampleItemID
        {
            get
            {
                return this._SampleItemID;
            }
            set
            {
                this._SampleItemID = value;
            }
        }

        public long SampleID
        {
            get
            {
                return this._SampleID;
            }
            set
            {
                this._SampleID = value;
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

        public int SampleTypeID { get; set; }
    }
}
