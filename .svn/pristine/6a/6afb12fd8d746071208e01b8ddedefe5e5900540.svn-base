using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmEmployeeTransfer
    {
        public HrmEmployeeTransfer()
        {
            HrmEtchoicePlaces = new HashSet<HrmEtchoicePlace>();
            HrmEtpreviousWorkPlaces = new HashSet<HrmEtpreviousWorkPlace>();
        }

        public long Id { get; set; }
        public int EmployementId { get; set; }
        public byte JoinDesignationId { get; set; }
        public DateTime ApplyDate { get; set; }
        public string TransferReason { get; set; } = null!;
        public int HomeDistrict { get; set; }
        public string? WorkingDuration { get; set; }
        public bool? IsActive { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual HrmPiemployement Employement { get; set; } = null!;
        public virtual ICollection<HrmEtchoicePlace> HrmEtchoicePlaces { get; set; }
        public virtual ICollection<HrmEtpreviousWorkPlace> HrmEtpreviousWorkPlaces { get; set; }
    }
}
