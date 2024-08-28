using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class AccAdvanceBackup
    {
        public long Id { get; set; }
        public int? EmployementId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public int ResEmployeeId { get; set; }
        public int? AreaId { get; set; }
        public int? DepoId { get; set; }
        public long Iemid { get; set; }
        public byte AdvanceTypeId { get; set; }
        public bool ReturnStatus { get; set; }
        public string? MiscellaneousAdvancePerson { get; set; }
        public string? MiscellaneousPersonMobileNo { get; set; }
        public string? MiscellaneousPurpose { get; set; }
        public string? Remarks { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
