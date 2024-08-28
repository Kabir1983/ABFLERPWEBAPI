using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetMonthlyActiveWorkingDay
    {
        public int Id { get; set; }
        public short Year { get; set; }
        public byte Month { get; set; }
        public byte NoOfWorkingDays { get; set; }
    }
}
