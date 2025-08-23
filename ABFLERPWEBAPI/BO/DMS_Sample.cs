using System.ComponentModel.DataAnnotations;

namespace ABFLERPWEBAPI.BO
{
    public class DMS_Sample
  {
    private IList<DMS_SampleItem> _SampleDetail = (IList<DMS_SampleItem>) new List<DMS_SampleItem>();
    private long _SampleID;
    private long _ChallanID;
    private int _SRID;
    private DateTime _SampleDate;
    private short _Day;
    private short _Month;
    private int _Year;
    private DateTime _LastUpdate;

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

    public int EmployementId
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

    public DateTime SampleDate
    {
      get
      {
        return this._SampleDate;
      }
      set
      {
        this._SampleDate = value;
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

    public IList<DMS_SampleItem> SampleDetailList
    {
      get
      {
        return this._SampleDetail;
      }
      set
      {
        this._SampleDetail = value;
      }
    }

    public int RouteID { get; set; }
  }
}
