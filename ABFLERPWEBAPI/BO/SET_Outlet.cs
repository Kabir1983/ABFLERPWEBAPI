namespace ABFLERPWEBAPI.BO
{
    public class SET_Outlet
    {
        private int _OutletID;
        private string _OutletCode;
        private string _OutletName;
        private string _Owner;
        private string _Address;
        private string _ContactNo;
        private int _RouteID;

        public int OutletID
        {
            get
            {
                return this._OutletID;
            }
            set
            {
                this._OutletID = value;
            }
        }

        public string OutletCode
        {
            get
            {
                return this._OutletCode;
            }
            set
            {
                this._OutletCode = value;
            }
        }

        public string OutletName
        {
            get
            {
                return this._OutletName;
            }
            set
            {
                this._OutletName = value;
            }
        }

        public string Owner
        {
            get
            {
                return this._Owner;
            }
            set
            {
                this._Owner = value;
            }
        }

        public string Address
        {
            get
            {
                return this._Address;
            }
            set
            {
                this._Address = value;
            }
        }

        public string ContactNo
        {
            get
            {
                return this._ContactNo;
            }
            set
            {
                this._ContactNo = value;
            }
        }

        public int RouteID
        {
            get
            {
                return this._RouteID;
            }
            set
            {
                this._RouteID = value;
            }
        }
        public DateTime LastUpdate { get; set; }
        public bool IsActive { get; set; }
        public string SRName { get; set; }
        public string RouteName { get; set; }
        public Decimal TotalPrice { get; set; }
        public int? RouteOutletNo { get; set; }
        public int? ClusterID { get; set; }
        public int AreaID { get; set; }
        public string DepoName { get; set; }
        public string RegionName { get; set; }
        public string AreaName { get; set; }
        public string TerritoryName { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public bool? IsNew { get; set; }
        public short BiriCigaretteStaus { get; set; }
        public string ClusterName { get; set; }
        public int DistrictID { get; set; }
        public string DistrictName { get; set; }
        public int ThanaID { get; set; }
        public string ThanaName { get; set; }
        public int UnionID { get; set; }
        public string UnionName { get; set; }
        public string Village { get; set; }
        public string Bazar { get; set; }
        public byte? DivisionID { get; set; }
        public string DivisionName { get; set; }
        public int ThanaId { get; set; }
        public int UnionId { get; set; }
        public byte? OutletTypeID { get; set; }
        public string OutletTypeName { get; set; }

    }
}
