namespace demoDevExpress.Entities
{
    public class ReportSection
    {
        public long ReportSectionId { get; set; }
        public long? ReportCategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public int? Order { get; set; }
        public bool? Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? DisplayColumn { get; set; }
    }
}
