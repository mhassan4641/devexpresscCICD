namespace demoDevExpress.Entities
{
    public class ReportCategory
    {
        public long ReportCategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public bool? Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string IconClass { get; set; }
        public int? Order { get; set; }
    }
}
