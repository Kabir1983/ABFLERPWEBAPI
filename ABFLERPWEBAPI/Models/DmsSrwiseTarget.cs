using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsSrwiseTarget
    {
        public long Id { get; set; }
        public long EmploymentId { get; set; }
        public int AreaId { get; set; }
        public int TerritoryId { get; set; }
        public int RouteId { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int OutletExistingQty { get; set; }
        public int OutletTargetQty { get; set; }
        public int OutletCoverageExistingQty { get; set; }
        public int OutletCoverageTargetQty { get; set; }
        public int MemoExistingQty { get; set; }
        public int MemoTargetQty { get; set; }
        public int OwnSalesExistingQty { get; set; }
        public int? AbrtargetQty { get; set; }
        public int? H25targetQty { get; set; }
        public int? H12targetQty { get; set; }
        public int? Ab8targetQty { get; set; }
        public int? K20targetQty { get; set; }
        public int? GbtargetQty { get; set; }
        public int? PbtargetQty { get; set; }
        public int OwnSalesTargetQty { get; set; }
        public int? SmokerDerbiQty { get; set; }
        public int? SmokerPilotQty { get; set; }
        public int? SmokerMerisQty { get; set; }
        public int? SmokerHoliwoodQty { get; set; }
        public int? SmokerShakeQty { get; set; }
        public int? SmokerOthersBiriQty { get; set; }
        public int? NapkinOutletExistingQty { get; set; }
        public int? NapkinOutletTargetQty { get; set; }
        public int? NapkinMemoExistingQty { get; set; }
        public int? NapkinMemoTargetQty { get; set; }
        public int? NapkinSalesExistingQty { get; set; }
        public int? NapkinSalesTargetQty { get; set; }
        public long ResEmployeeId { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
