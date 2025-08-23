using System.ComponentModel.DataAnnotations;

namespace ABFLERPWEBAPI.BO
{
    public class SET_SalesTargetTypeInc
  {
    public short ID { get; set; }

    public string TargetType { get; set; }
    public string Description { get; set; }

    public bool IsActive { get; set; } 
    public DateTime LastUpdate { get; set; }

    public int MemoStart { get; set; }

    public int MemoEnd { get; set; }

    public int TotalMemo { get; set; }
  }
}
