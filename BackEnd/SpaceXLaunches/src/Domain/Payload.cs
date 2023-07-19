using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Payload : BaseEntity
    {
        public string payload_id { get; set; }
        public List<int> norad_id { get; set; }
        public bool reused { get; set; }
        public List<string> customers { get; set; }
        public string nationality { get; set; }
        public string manufacturer { get; set; }
        public string payload_type { get; set; }
        public double? payload_mass_kg { get; set; }
        public double? payload_mass_lbs { get; set; }
        public string orbit { get; set; }
        public OrbitParams orbit_params { get; set; }
        public string cap_serial { get; set; }
        public double? mass_returned_kg { get; set; }
        public double? mass_returned_lbs { get; set; }
        public int? flight_time_sec { get; set; }
        public string cargo_manifest { get; set; }
        public string uid { get; set; }
    }


}
