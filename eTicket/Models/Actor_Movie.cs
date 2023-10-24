namespace eTicket.Models
{
    public class Actor_Movie
    {
        //join class
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int ActorId { get; set; }
        public Actor Actor { get; set; }//one to many
        //bu sınıf sadece bir film ve aktöre sahip olabilir (film ve actör id si özelinde)

    }
}
