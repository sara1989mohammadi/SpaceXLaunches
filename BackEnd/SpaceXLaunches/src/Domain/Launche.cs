using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Launche : BaseEntity
    {
        public int flight_number { get; set; }
        public string mission_name { get; set; }
        public List<string> mission_id { get; set; }
        public bool upcoming { get; set; }
        public string launch_year { get; set; }
        public int launch_date_unix { get; set; }
        public DateTime launch_date_utc { get; set; }
        public DateTime launch_date_local { get; set; }
        public bool is_tentative { get; set; }
        public string tentative_max_precision { get; set; }
        public bool tbd { get; set; }
        public int? launch_window { get; set; }
        public Rocket rocket { get; set; }
        public List<string> ships { get; set; }
        public Telemetry telemetry { get; set; }
        public LaunchSite launch_site { get; set; }
        public bool? launch_success { get; set; }
        public LaunchFailureDetails launch_failure_details { get; set; }
        public Links links { get; set; }
        public string details { get; set; }
        public DateTime? static_fire_date_utc { get; set; }
        public int? static_fire_date_unix { get; set; }
        public Timeline timeline { get; set; }
        public List<object> crew { get; set; }
        public DateTime? last_date_update { get; set; }
        public DateTime? last_ll_launch_date { get; set; }
        public DateTime? last_ll_update { get; set; }
        public DateTime? last_wiki_launch_date { get; set; }
        public string last_wiki_revision { get; set; }
        public DateTime? last_wiki_update { get; set; }
        public string launch_date_source { get; set; }
    }
}
