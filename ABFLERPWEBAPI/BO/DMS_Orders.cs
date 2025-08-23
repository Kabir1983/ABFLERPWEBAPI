using System.ComponentModel.DataAnnotations;

namespace ABFLERPWEBAPI.BO
{
    public class DMS_Orders
  {
    private IList<DMS_OrderDetail> _OrderDetail = (IList<DMS_OrderDetail>) new List<DMS_OrderDetail>();
    private long _OrderID;
    private long _ChallanID;
    private int _SRID;
    private int _OutletID;
    private DateTime _OrderDate;
    private short _Day;
    private short _Month;
    private int _Year;
    private DateTime _LastUpdate;

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

    public int EmployementID
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

    public DateTime OrderDate
    {
      get
      {
        return this._OrderDate;
      }
      set
      {
        this._OrderDate = value;
      }
    }

    public short Day
    {
      get
      {
        return this._Day;
      }
      set
      {
        this._Day = value;
      }
    }

    public short Month
    {
      get
      {
        return this._Month;
      }
      set
      {
        this._Month = value;
      }
    }

    public int Year
    {
      get
      {
        return this._Year;
      }
      set
      {
        this._Year = value;
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

    public IList<DMS_OrderDetail> OrderDetail
    {
      get
      {
        return this._OrderDetail;
      }
      set
      {
        this._OrderDetail = value;
      }
    }

    public long? MemoStart { get; set; }

    public long? MemoEnd { get; set; }

    public byte? DivisionID { get; set; }

    public int? DepoID { get; set; }

    public int? RegionID { get; set; }

    public int? AreaID { get; set; }

    public int? TerritoryID { get; set; }

    public int? RouteID { get; set; }

    public bool? IsPointOrder { get; set; }
  }
}
