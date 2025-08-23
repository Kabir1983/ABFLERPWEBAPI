using System.ComponentModel.DataAnnotations;

namespace ABFLERPWEBAPI.BO
{
    public class DMS_AreaDeliveryChallan
  {
    private IList<DMS_AreaDeliveryChallanItem> _AreaDeliveryChallanItemList = (IList<DMS_AreaDeliveryChallanItem>) new List<DMS_AreaDeliveryChallanItem>();
    private IList<DMS_AreaDeliveryChallanItem> _UpdateAreaDeliveryChallanItemList = (IList<DMS_AreaDeliveryChallanItem>) new List<DMS_AreaDeliveryChallanItem>();
    private IList<DMS_AreaDeliveryChallanItem> _NewAreaDeliveryChallanItemList = (IList<DMS_AreaDeliveryChallanItem>) new List<DMS_AreaDeliveryChallanItem>();
    private IList<DMS_AreaStock> _areaStockList = (IList<DMS_AreaStock>) new List<DMS_AreaStock>();
    private IList<SET_NoteAndCoinInfo> _NoteAndCoinInfoList = (IList<SET_NoteAndCoinInfo>) new List<SET_NoteAndCoinInfo>();
    private IList<SET_ChallanPurpose> _ChallanPurposeList = (IList<SET_ChallanPurpose>) new List<SET_ChallanPurpose>();
    private long _ChallanID;
    private string _ChallanNo;
    private int _SRID;
    private long _AreaID;
    private int _RouteID;
    private int _ChallanByID;
    private bool _IsApprovedByAM;
    private bool _IsApprovedByAccounts;
    private string _Remarks;
    private DateTime _LastUpdate;
    private string _Driver;
    private string _VanNo;

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

    public string ChallanNo
    {
      get
      {
        return this._ChallanNo;
      }
      set
      {
        this._ChallanNo = value;
      }
    }

    public int SRID
    {
      get
      {
        return this._SRID;
      }
      set
      {
        this._SRID = value;
      }
    }

    public long DepoID
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

    public int ChallanByID
    {
      get
      {
        return this._ChallanByID;
      }
      set
      {
        this._ChallanByID = value;
      }
    }

    public bool IsApprovedByAM
    {
      get
      {
        return this._IsApprovedByAM;
      }
      set
      {
        this._IsApprovedByAM = value;
      }
    }

    public bool IsApprovedByAccounts
    {
      get
      {
        return this._IsApprovedByAccounts;
      }
      set
      {
        this._IsApprovedByAccounts = value;
      }
    }

    public string Remarks
    {
      get
      {
        return this._Remarks;
      }
      set
      {
        this._Remarks = value;
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

    public string Driver
    {
      get
      {
        return this._Driver;
      }
      set
      {
        this._Driver = value;
      }
    }

    public string VanNo
    {
      get
      {
        return this._VanNo;
      }
      set
      {
        this._VanNo = value;
      }
    }

    public IList<DMS_AreaDeliveryChallanItem> AreaDeliveryChallanItemList
    {
      get
      {
        return this._AreaDeliveryChallanItemList;
      }
      set
      {
        this._AreaDeliveryChallanItemList = value;
      }
    }

    public IList<DMS_AreaDeliveryChallanItem> UpdateAreaDeliveryChallanItemList
    {
      get
      {
        return this._UpdateAreaDeliveryChallanItemList;
      }
      set
      {
        this._UpdateAreaDeliveryChallanItemList = value;
      }
    }

    public IList<DMS_AreaDeliveryChallanItem> NewAreaDeliveryChallanItemList
    {
      get
      {
        return this._NewAreaDeliveryChallanItemList;
      }
      set
      {
        this._NewAreaDeliveryChallanItemList = value;
      }
    }

    public IList<DMS_AreaStock> areaStockList
    {
      get
      {
        return this._areaStockList;
      }
      set
      {
        this._areaStockList = value;
      }
    }

    public IList<SET_NoteAndCoinInfo> NoteAndCoinInfoList
    {
      get
      {
        return this._NoteAndCoinInfoList;
      }
      set
      {
        this._NoteAndCoinInfoList = value;
      }
    }

    public IList<SET_ChallanPurpose> ChallanPurposeList
    {
      get
      {
        return this._ChallanPurposeList;
      }
      set
      {
        this._ChallanPurposeList = value;
      }
    }

    public int AreaID { get; set; }

    public DateTime ChallanDate { get; set; }

    public Decimal ChallanAmount { get; set; }

    public int TotalChallanQty { get; set; }

    public int Status { get; set; }

    public string PointChallanNo { get; set; }

    public List<DMS_Orders> Order { get; set; }

    public string MChallanNo { get; set; }

    public bool? IsOrderClosed { get; set; }

    public long? IEID { get; set; }

    public string AlternetSR { get; set; }

    public int? TerritoryID { get; set; }

    public bool? IsDealer { get; set; }

    public int DellarID { get; set; }
  }
}
