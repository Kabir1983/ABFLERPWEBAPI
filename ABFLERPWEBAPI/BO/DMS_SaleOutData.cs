using System.ComponentModel.DataAnnotations;

namespace ABFLERPWEBAPI.BO
{
    public class DMS_SaleOutData
    {
        private DMS_Orders _Sale = new DMS_Orders();
        private DMS_Sample _Sample = new DMS_Sample();
        private DMS_DamageMaster _Damage = new DMS_DamageMaster();
        private DMS_IncentiveMaster _Incentive = new DMS_IncentiveMaster();
        private DMS_BPacketMaster _BPacket = new DMS_BPacketMaster();
        private ACC_IncomeExpenseMaster objIncome = new ACC_IncomeExpenseMaster();
        private DMS_AreaDeliveryChallan objChallan = new DMS_AreaDeliveryChallan();
        private List<DMS_OrdersForPoint> _SalePoint = new List<DMS_OrdersForPoint>();

        public DMS_Orders OrderSale
        {
            get
            {
                return this._Sale;
            }
            set
            {
                this._Sale = value;
            }
        }

        public DMS_Sample Sample
        {
            get
            {
                return this._Sample;
            }
            set
            {
                this._Sample = value;
            }
        }

        public DMS_DamageMaster Damage
        {
            get
            {
                return this._Damage;
            }
            set
            {
                this._Damage = value;
            }
        }

        public DMS_IncentiveMaster Incentive
        {
            get
            {
                return this._Incentive;
            }
            set
            {
                this._Incentive = value;
            }
        }

        public DMS_BPacketMaster BPacket
        {
            get
            {
                return this._BPacket;
            }
            set
            {
                this._BPacket = value;
            }
        }

        public ACC_IncomeExpenseMaster SaleIncome
        {
            get
            {
                return this.objIncome;
            }
            set
            {
                this.objIncome = value;
            }
        }

        public DMS_AreaDeliveryChallan AreaChallan
        {
            get
            {
                return this.objChallan;
            }
            set
            {
                this.objChallan = value;
            }
        }

        public long ChallanID { get; set; }

        public int AreaID { get; set; }

        public List<DMS_OrdersForPoint> OrderSalePoint
        {
            get
            {
                return this._SalePoint;
            }
            set
            {
                this._SalePoint = value;
            }
        }

        public int TerriotryID { get; set; }
    }
}
