namespace Models
{
    public class OCPPRequest
    {
        public string MessageTypeId { get; set; }
        public string MessageId { get; set; }
        public string Action { get; set; }
        public string Payload { get; set; }
    }
}