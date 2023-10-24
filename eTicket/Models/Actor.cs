using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace eTicket.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Profile picture")]
        [Required(ErrorMessage ="Profile picture is required")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Actor Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 chars")]
        public string FullName { get; set;}
        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Actor Biography is required")]
        public string Bio {  get; set; }

        //ilişkiler
        public List<Actor_Movie> Actors_Movies { get; set; }//bir actörün birden fazla filmi olabilir. bunu actor_movie join classı ile ilişkilendirdik
    }
}
