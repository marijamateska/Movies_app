using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aud10.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name ="First name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last name")]
        public string LastName { get; set; }
        [Range(10,99)]
        public int Age { get; set; }
        [Required]
        public string Email { get; set; }
        public virtual List<Movie> movies { get; set; }
        public Client()
        {
            movies = new List<Movie>();
        }
    }
}