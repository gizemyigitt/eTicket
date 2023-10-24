using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eTicket.Data.Enums;

namespace eTicket.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double price { get; set; }

        public string ImageURL { get; set; }
        public DateTime StartdDate { get; set; }
        public DateTime EndDate { get; set;}

        public MovieCategory MovieCategory { get; set; }

        //ilişkiler
        public List<Actor_Movie> Actors_Movies { get; set; }//bir filmin birden fazla oyuncusu olabilir

        //Cinema ilişkisi birden fazla film tek bi cinema olabilir
        public int CinemaId { get; set; }//foreignkey
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        //Producer ilişkisi birden fazla film tek bi producer olabilir
        public int ProducerId { get; set; }//foreignkey
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }

    }
}
