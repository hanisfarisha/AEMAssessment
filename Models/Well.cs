namespace AEMTest.Models
{
    public class Well
    {
        public int WellId { get; set; }
        public int PlatformId { get; set; }
        public Platform Platform { get; set; }
        public string WellString { get; set; }
        public DateTimeOffset CreatedDatetime { get; set; }
        public DateTimeOffset UpdatedDatetime { get; set; }
        public bool Deleted { get; set; }

    }
}
