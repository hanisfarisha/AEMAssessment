using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AEMTest.Models
{
    public class Platform
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PlatformId { get; set; }
        public string PlatformCode { get; set; }
        public string PlatformName { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }

        public DateTimeOffset CreatedDatetime { get; set; }
        public DateTimeOffset UpdatedDatetime { get; set; }
        public bool Deleted { get; set; }
    }
}
