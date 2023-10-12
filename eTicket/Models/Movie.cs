using System.ComponentModel.DataAnnotations;
using eTicket.Data;

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

    
    }
}
