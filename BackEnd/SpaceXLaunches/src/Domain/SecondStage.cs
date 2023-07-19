namespace Domain
{
    public class SecondStage : BaseEntity
    {
        public int? block { get; set; }
        public List<Payload> payloads { get; set; }
    }


}
