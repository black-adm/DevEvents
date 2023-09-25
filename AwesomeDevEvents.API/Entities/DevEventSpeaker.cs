namespace AwesomeDevEvents.API.Entities
{
    public class DevEventSpeaker
    {
        public Guid ID { get; set; }
        public string? Name { get; set; }
        public string? TalkTitle {  get; set; }
        public string? TalkDescription {  get; set; }
        public string? LinkedinProfile { get; set; }
        public Guid DevEventID { get; set; }
    }
}
