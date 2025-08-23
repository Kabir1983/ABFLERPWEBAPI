using System.ComponentModel.DataAnnotations;

namespace ABFLERPWEBAPI.BO
{
    public class DMS_DamageMaster
  {
    private IList<DMS_DamageDetail> _DamageDetail = (IList<DMS_DamageDetail>) new List<DMS_DamageDetail>();
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

    public IList<DMS_DamageDetail> DamageDetail
    {
      get
      {
        return this._DamageDetail;
      }
      set
      {
        this._DamageDetail = value;
      }
    }

    public DateTime Date { get; set; }
  }
}
