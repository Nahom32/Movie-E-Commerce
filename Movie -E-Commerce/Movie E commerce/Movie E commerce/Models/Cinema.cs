using System.ComponentModel.DataAnnotations;

namespace Movie_E_commerce.Models
{
    public class Cinema
    {
        public int Id { get; set; }
        [Display(Name= "Cinema Name")]
        public string Name { get; set; }
        [Display(Name = "About Us")]
        public string Description { get; set; }
        public List<Movie> Movies{ get; set;}
        public string Logo{ get; set; }

    }
}
