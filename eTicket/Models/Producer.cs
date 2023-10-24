using System.ComponentModel.DataAnnotations;

namespace eTicket.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //İlişkiler
        public List<Movie> Movies { get; set; }//bir producer ın birden fazla filmi olabiliir
    }
}
