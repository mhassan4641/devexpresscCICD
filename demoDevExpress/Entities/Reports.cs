namespace demoDevExpress.Entities
{
    public class Reports
    {
        public long ReportId { get; set; }
        public string Title { get; set; }
        public string ReportPath { get; set; }
        public long? ReportCategoryId { get; set; }
        public long? ReportSectionId { get; set; }
        public int? Order { get; set; }
        public string Color { get; set; }
        public bool? Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ReportContentPlainText { get; set; }
        public string Tenants { get; set; }
        public string UserRoles { get; set; }
        public string ReportComponents { get; set; }
    }
    public class NewReports
    {
        public long ReportId { get; set; }
        public string Title { get; set; }
        public string CommonReportPath { get; set; } // only one path
        public string CusutomReportPath { get; set; } // comma seperated paths of multiple customized reports 
        public bool? Status { get; set; }
        public string Tenants { get; set; }
        public string UserRoles { get; set; }
        public string ReportComponents { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
