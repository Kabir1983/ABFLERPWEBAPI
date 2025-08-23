using System.ComponentModel.DataAnnotations;

namespace ABFLERPWEBAPI.BO
{
    public class DMS_BPacketStock
  {
    private long _BPSID;
    private int _AreaID;
    private short _ProductID;
    private long _Qty;

    public long BPSID
    {
      get
      {
        return this._BPSID;
      }
      set
      {
        this._BPSID = value;
      }
    }

    public int AreaID
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

    public short ProductID
    {
      get
      {
        return this._ProductID;
      }
      set
      {
        this._ProductID = value;
      }
    }

    public long Qty
    {
      get
      {
        return this._Qty;
      }
      set
      {
        this._Qty = value;
      }
    }

    public long Balance { get; set; }

    public DateTime LastUpdate { get; set; }
  }
}
