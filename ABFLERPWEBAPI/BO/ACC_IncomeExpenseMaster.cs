using System.ComponentModel.DataAnnotations;

namespace ABFLERPWEBAPI.BO
{
    public class ACC_IncomeExpenseMaster
  {
    private List<ACC_IncomeExpense> _IncomeExpense = new List<ACC_IncomeExpense>();
    private long _ID;
    private int? _PayToID;
    private Decimal _Amount;
    private int? _ResponsibleID;
    private DateTime _PayTime;
    private short _PurposeID;

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

    public int? PayToID
    {
      get
      {
        return this._PayToID;
      }
      set
      {
        this._PayToID = value;
      }
    }

    public Decimal Amount
    {
      get
      {
        return this._Amount;
      }
      set
      {
        this._Amount = value;
      }
    }

    public int? ResponsibleID
    {
      get
      {
        return this._ResponsibleID;
      }
      set
      {
        this._ResponsibleID = value;
      }
    }

    public DateTime PayTime
    {
      get
      {
        return this._PayTime;
      }
      set
      {
        this._PayTime = value;
      }
    }

    public short PurposeID
    {
      get
      {
        return this._PurposeID;
      }
      set
      {
        this._PurposeID = value;
      }
    }

    public List<ACC_IncomeExpense> IncomeExpense
    {
      get
      {
        return this._IncomeExpense;
      }
      set
      {
        this._IncomeExpense = value;
      }
    }

    public string VoucherNo { get; set; }

    public short? IncomeExpenseTypeID { get; set; }

    public int? DepoID { get; set; }

    public string Remarks { get; set; }

    public int? AreaID { get; set; }

    public int? RegionID { get; set; }

    public byte? FactoryID { get; set; }

    public bool IsHeadOffice { get; set; }

    public string Description { get; set; }

    public int IEHeader { get; set; }

    public DateTime PayDate { get; set; }

    public Decimal Balance { get; set; }

    public DateTime IEDate { get; set; }

    public int? DealerID { get; set; }
  }
}
