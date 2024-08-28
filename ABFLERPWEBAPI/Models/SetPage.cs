using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetPage
    {
        public SetPage()
        {
            SetPostWisePages = new HashSet<SetPostWisePage>();
        }

        public int PageId { get; set; }
        public string PageName { get; set; } = null!;

        public virtual ICollection<SetPostWisePage> SetPostWisePages { get; set; }
    }
}
