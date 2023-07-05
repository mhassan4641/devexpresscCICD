namespace demoDevExpress.Entities
{
    public class Configuration
    {
        public long ConfigID { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public bool Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
