using System.ComponentModel.DataAnnotations;

namespace ABFLERPWEBAPI.BO
{
    public class ACC_IncomeExpense
    {
        private long _ID;
        private int? _PayToID;
        private Decimal _Amount;
        private int _ResponsibleID;
        private DateTime _PayTime;
        private short _PurposeID;

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

        public int? PayToID
        {
            get
            {
                return this._PayToID;
            }
            set
            {
                this._PayToID = value;
            }
        }

        public Decimal Amount
        {
            get
            {
                return this._Amount;
            }
            set
            {
                this._Amount = value;
            }
        }

        public int ResponsibleID
        {
            get
            {
                return this._ResponsibleID;
            }
            set
            {
                this._ResponsibleID = value;
            }
        }

        public DateTime PayTime
        {
            get
            {
                return this._PayTime;
            }
            set
            {
                this._PayTime = value;
            }
        }

        public short PurposeID
        {
            get
            {
                return this._PurposeID;
            }
            set
            {
                this._PurposeID = value;
            }
        }

        public string Description { get; set; }

        public long IEMasterID { get; set; }

        public int Sln { get; set; }

        public string ExpenseName { get; set; }

        public string EmployeeName { get; set; }

        public int? DepoID { get; set; }

        public int AreaID { get; set; }

        public int RegionID { get; set; }

        public byte FactoryID { get; set; }

        public bool? IsHeadOffice { get; set; }

        public Decimal AreaClosingBalance { get; set; }

        public Decimal HeadOfficeClosingBalance { get; set; }
    }
}
