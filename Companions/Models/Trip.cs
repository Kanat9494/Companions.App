namespace Companions.Models;

internal class Trip
{
    public int TripId { get; set; }
    public string TripName { get; set;} 
    public string TripDescription { get; set;}
    List<string> TripTags { get; set; } = new List<string>();
    public short IsActive { get; set; }
}
