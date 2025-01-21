public class RandomMajorEvent()
{
    public int Id { get; set; }
    public int MajorEventTypeId { get; set; }
    public string EventTitle { get; set; }
    public string Description { get; set; }
    public List<EventChoice> Choices = new List<EventChoice>();
}
