using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class LaunchSite : BaseEntity
    {
        public string site_id { get; set; }
        public string site_name { get; set; }
        public string site_name_long { get; set; }
    }


}
