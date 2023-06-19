namespace ReviewApp.Models
{
    public class Studio
    {
        public int Id { get; set; }    
        public string Name { get; set; }    
        public string Style { get; set; } 
        public Location Location  { get; set; }
        public ICollection<AnimeStudio> AnimeStudios { get; set; }
    }
}
