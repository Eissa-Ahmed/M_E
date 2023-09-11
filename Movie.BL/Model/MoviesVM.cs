using Movie.DAL.Entity;

namespace Movie.BL.Model
{
    public class MoviesVM
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Poster { get; set; }
        public string Video { get; set; }
        public int GenerId { get; set; }
        public Gener? Gener { get; set; }
    }
}
