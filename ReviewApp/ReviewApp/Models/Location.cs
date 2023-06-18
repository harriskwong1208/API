namespace ReviewApp.Models
{
    public class Location
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public ICollection<Studio> Studios { get; set; }
    }
}
