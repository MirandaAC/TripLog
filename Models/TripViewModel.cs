namespace TripLog.Models
{
    public class TripViewModel
    {
        public Trip trip { get; set; } = new Trip();
        public int PageNum { get; set; }
    }
}
