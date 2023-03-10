using Movie_E_commerce.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movie_E_commerce.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Movie Name")]
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        [Display(Name = "Image")]
        public string ImageURL { get; set; }
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }
        [Display(Name = "Movie Category")]
        public MovieCategory Category { get; set; }
        public List<Actor_Movie> Actors_Movies{ get; set; }
        
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }




    }
}
