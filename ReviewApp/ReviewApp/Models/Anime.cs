using System.Data;

namespace ReviewApp.Models
{
    public class Anime
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public DataSetDateTime BroadcastDate { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
