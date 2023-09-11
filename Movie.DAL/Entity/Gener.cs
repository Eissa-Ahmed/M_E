namespace Movie.DAL.Entity
{
    public class Gener
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Movies> Movies { get; set;}
    }
}
