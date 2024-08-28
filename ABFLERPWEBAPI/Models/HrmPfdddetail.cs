using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmPfdddetail
    {
        public int Id { get; set; }
        public int Pfddid { get; set; }
        public int PfaccId { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal CompanyShare { get; set; }
        public decimal EmployeeShare { get; set; }
        public decimal Graturity { get; set; }
        public long TransactionId { get; set; }
        public byte Month { get; set; }
        public short Year { get; set; }
        public byte TranStatus { get; set; }

        public virtual HrmPfaccount Pfacc { get; set; } = null!;
        public virtual HrmPfddinfo Pfdd { get; set; } = null!;
        public virtual HrmPftransaction Transaction { get; set; } = null!;
    }
}
