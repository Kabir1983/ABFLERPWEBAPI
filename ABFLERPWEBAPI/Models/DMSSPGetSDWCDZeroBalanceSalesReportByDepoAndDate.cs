using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ABFLERPWEBAPI.Models
{
    [Keyless]
    public class DMSSPGetSDWCDZeroBalanceSalesReportByDepoAndDate
    {


        public long ID { get; set; }
        public DateTime? Date { get; set; }
        public string? DOName { get; set; }
        public string? HOOName { get; set; }
        public int? SoleDepotID { get; set; }
        public Int16? ProductID { get; set; }
        public string? ProductName { get; set; }
        public byte? Sticks { get; set; }
        public decimal? TP { get; set; }
        public int ZBRIID { get; set; }
        public int? TranType { get; set; }
        public int? SubTranType { get; set; }
        public decimal? Total { get; set; }
        public decimal? TotalAmount { get; set; }
        public string? Remarks { get; set; }
        public int? DOID { get; set; }
        public int? HOID { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? LastUpdate { get; set; }

    }
}