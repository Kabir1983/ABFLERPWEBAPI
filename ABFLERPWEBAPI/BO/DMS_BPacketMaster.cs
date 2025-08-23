using System.ComponentModel.DataAnnotations;

namespace ABFLERPWEBAPI.BO
{
    public class DMS_BPacketMaster
  {
    private IList<DMS_BPacketDetail> _BPacketDetail = (IList<DMS_BPacketDetail>) new List<DMS_BPacketDetail>();
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

    public IList<DMS_BPacketDetail> BPacketDetail
    {
      get
      {
        return this._BPacketDetail;
      }
      set
      {
        this._BPacketDetail = value;
      }
    }

    public DateTime Date { get; set; }
  }
}
