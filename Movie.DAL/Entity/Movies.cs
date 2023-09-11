namespace Movie.DAL.Entity
{
    public class Movies
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Poster { get; set; }
        public string Video { get; set; }
        [ForeignKey("Gener")]
        public int GenerId { get; set; }
        public Gener Gener { get; set; }
    }
}
