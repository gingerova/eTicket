using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTicket.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Producer Picture")]
        public string ProfilePicture { get; set; }
        [Display(Name = "Producer Name")]
        public string ProducerName { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //Relationships

        public List<Movie> Movies { get; set; }

    }
}
