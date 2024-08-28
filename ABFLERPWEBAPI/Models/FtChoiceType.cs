using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class FtChoiceType
    {
        public FtChoiceType()
        {
            HrmEtchoicePlaces = new HashSet<HrmEtchoicePlace>();
        }

        public byte Id { get; set; }
        public string ChoiceType { get; set; } = null!;

        public virtual ICollection<HrmEtchoicePlace> HrmEtchoicePlaces { get; set; }
    }
}
