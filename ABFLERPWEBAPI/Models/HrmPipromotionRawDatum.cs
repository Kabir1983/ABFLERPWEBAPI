using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmPipromotionRawDatum
    {
        public int Id { get; set; }
        public int Pisid { get; set; }
        public byte EmployeeCategoryId { get; set; }
        public byte JobPositionId { get; set; }
        public byte PayGradeId { get; set; }
        public byte DesignationId { get; set; }
        public byte EffectiveMonth { get; set; }
        public short EffectiveYear { get; set; }
        public bool IsProcess { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
