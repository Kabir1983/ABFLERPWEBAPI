﻿using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsNapkinAreaOpeningStock
    {
        public long Id { get; set; }
        public int AreaId { get; set; }
        public short ProductId { get; set; }
        public long Qty { get; set; }
        public long Asid { get; set; }
        public int InsertUserId { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual DmsNapkinAreaStock As { get; set; } = null!;
        public virtual SetNapkinProduct Product { get; set; } = null!;
    }
}
