using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetUserMessage
    {
        public long MessageId { get; set; }
        public DateTime Date { get; set; }
        public int SenderId { get; set; }
        public string? Subject { get; set; }
        public string MessageBody { get; set; } = null!;
        public bool IsActive { get; set; }
    }
}
