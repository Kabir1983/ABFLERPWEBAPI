using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmTourAttendance
    {
        public HrmTourAttendance()
        {
            HrmTourAttendanceDetails = new HashSet<HrmTourAttendanceDetail>();
        }

        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public byte TourTypeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public byte TotalDays { get; set; }
        public string TourName { get; set; } = null!;
        public DateTime? LastUpdate { get; set; }

        public virtual SetTourType TourType { get; set; } = null!;
        public virtual ICollection<HrmTourAttendanceDetail> HrmTourAttendanceDetails { get; set; }
    }
}
