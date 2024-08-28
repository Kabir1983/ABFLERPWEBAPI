﻿using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmPreviousEmployeement
    {
        public int Id { get; set; }
        public int Piid { get; set; }
        public byte? EmployeeCategoryId { get; set; }
        public byte? JobPositionId { get; set; }
        public byte? PayGradeId { get; set; }
        public bool? InHeadOffice { get; set; }
        public byte? FactoryId { get; set; }
        public int? DepoId { get; set; }
        public int? RegionId { get; set; }
        public int? AreaId { get; set; }
        public int? TerritoryId { get; set; }
        public byte DesignationId { get; set; }
        public byte? DivisionId { get; set; }
        public byte? DepartmentId { get; set; }
        public byte? SectionId { get; set; }
        public DateTime JoiningDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? PpstartDate { get; set; }
        public DateTime? PpendDate { get; set; }
        public byte? AgreementTypeId { get; set; }
        public decimal Basic { get; set; }
        public bool? IsBonusApplicable { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
