namespace ABFLERPWEBAPI.BO
{
    public class SetDepo
    {
        public int DepoId { get; set; }
        public int? Sln { get; set; }
        public string Name { get; set; } = null!;
        public string? Code { get; set; }
        public string? Address { get; set; }
        public bool? IsActive { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
