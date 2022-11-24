using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTicket.Models
{
    public class Actor
    {
        [Key]
        public int Id {get; set; }
        [Display(Name ="Actor Picture")]
        public string ProfilePicture { get; set; }
        [Display(Name = "Actor Name")]
        public string ActorName { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }

        public List<ActorMovie> ActorMovie { get; set; }
    }
}
