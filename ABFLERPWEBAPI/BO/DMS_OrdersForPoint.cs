using System.ComponentModel.DataAnnotations;

namespace ABFLERPWEBAPI.BO
{
    public class DMS_OrdersForPoint
  {
    private IList<DMS_OrderDetailForPoint> _OrderDetail = (IList<DMS_OrderDetailForPoint>) new List<DMS_OrderDetailForPoint>();
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

    public IList<DMS_OrderDetailForPoint> OrderDetail
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
  }
}
