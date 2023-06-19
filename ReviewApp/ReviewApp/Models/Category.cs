namespace ReviewApp.Models
{
    public class Category
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public ICollection<AnimeCategory> AnimeCategories { get; set; }
    }
}
