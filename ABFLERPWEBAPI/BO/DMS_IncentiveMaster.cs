using System.ComponentModel.DataAnnotations;

namespace ABFLERPWEBAPI.BO
{
    public class DMS_IncentiveMaster
  {
    private IList<DMS_IncentiveDetail> _IncentiveDetail = (IList<DMS_IncentiveDetail>) new List<DMS_IncentiveDetail>();
    private long _ID;
    private long _ChallanID;
    private int _EmployementID;
    private DateTime _LastUpdate;

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
        return this._EmployementID;
      }
      set
      {
        this._EmployementID = value;
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

    public IList<DMS_IncentiveDetail> IncentiveDetailList
    {
      get
      {
        return this._IncentiveDetail;
      }
      set
      {
        this.IncentiveDetailList = value;
      }
    }

    public DateTime Date { get; set; }
  }
}
