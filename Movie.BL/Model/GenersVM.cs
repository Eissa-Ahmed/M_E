using Movie.DAL.Entity;

namespace Movie.BL.Model
{
    public class GenersVM
    {
        public string Name { get; set; }
        public IEnumerable<Movies>? Movies { get; set; }
    }
}
