namespace Movie_E_commerce.Models
{
    public class Cinema
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Movie> Movies{ get; set;}
        public string Logo{ get; set; }

    }
}
