public class RandomMajorEventDTO()
{
    public int Id { get; set; }
    public int MajorEventTypeId { get; set; }
    public string EventTitle { get; set; }
    public string Description { get; set; }
    public List<EventChoicesDTO> Choices { get; set; } = new List<EventChoicesDTO>();
}
