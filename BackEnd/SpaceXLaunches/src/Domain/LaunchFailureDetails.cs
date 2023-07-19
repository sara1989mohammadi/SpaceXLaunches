namespace Domain
{
    public class LaunchFailureDetails : BaseEntity
    {
        public int time { get; set; }
        public int? altitude { get; set; }
        public string reason { get; set; }
    }


}
