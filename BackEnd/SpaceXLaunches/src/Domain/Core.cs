using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Core : BaseEntity
    {
        public string core_serial { get; set; }
        public int? flight { get; set; }
        public int? block { get; set; }
        public bool? gridfins { get; set; }
        public bool? legs { get; set; }
        public bool? reused { get; set; }
        public bool? land_success { get; set; }
        public bool? landing_intent { get; set; }
        public string landing_type { get; set; }
        public string landing_vehicle { get; set; }
    }


}
