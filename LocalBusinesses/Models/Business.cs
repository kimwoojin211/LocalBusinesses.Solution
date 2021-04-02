namespace LocalBusinesses.Models
{
  public class Business
  {
    public int BusinessId { get; set; }
    public string Name { get; set; }

    public string Category { get; set; }
    public string OwnedBy { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }

    public string HoursOpen { get; set; }

    public string HoursClose { get; set; }

  }
}