﻿using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsOrder
    {
        public DmsOrder()
        {
            DmsOrderDetails = new HashSet<DmsOrderDetail>();
        }

        public long OrderId { get; set; }
        public long ChallanId { get; set; }
        public int EmployeementId { get; set; }
        public DateTime OrderDate { get; set; }
        public int? OutletId { get; set; }
        public byte Day { get; set; }
        public byte Month { get; set; }
        public short Year { get; set; }
        public DateTime LastUpdate { get; set; }
        public string? OrderTime { get; set; }

        public virtual HrmPiemployement Employeement { get; set; } = null!;
        public virtual SetOutlet? Outlet { get; set; }
        public virtual ICollection<DmsOrderDetail> DmsOrderDetails { get; set; }
    }
}
