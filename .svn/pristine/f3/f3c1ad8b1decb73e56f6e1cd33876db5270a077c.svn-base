using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsRequisionIndentation
    {
        public DmsRequisionIndentation()
        {
            DmsRequisitionIndentationDetails = new HashSet<DmsRequisitionIndentationDetail>();
        }

        public int IndentationId { get; set; }
        public string IndentationNo { get; set; } = null!;
        public DateTime Date { get; set; }
        public byte Month { get; set; }
        public short Year { get; set; }
        public int FactoryId { get; set; }
        public int? RegionId { get; set; }
        public int DepoId { get; set; }
        public int IndentById { get; set; }
        public int Dmid { get; set; }
        public string? Remarks { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual SetDepo Depo { get; set; } = null!;
        public virtual ICollection<DmsRequisitionIndentationDetail> DmsRequisitionIndentationDetails { get; set; }
    }
}
