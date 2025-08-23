namespace ABFLERPWEBAPI.BO
{
    public class OutletVisit
    {
        public long ID { get; set; }
        public long TourPlanID { get; set; }
        public DateTime Date { get; set; }
        public int? EmploymentID { get; set; }
        public int RouteID { get; set; }
        public int ClusterID { get; set; }
        public int OutletID { get; set; }
        public string OutletName { get; set; }
        public string ContactNo { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public string? GPSAddress { get; set; }

        public List<OutletVisitDetails>? Details { get; set; } = new List<OutletVisitDetails>();
    }
}
