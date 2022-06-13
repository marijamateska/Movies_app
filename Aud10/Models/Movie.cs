using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aud10.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Range(0.0, 5.0)]
        public double Rating { get; set; }
        public string ImgUrl { get; set; }
        public virtual List<Client> clients { get; set; }
        public Movie()
        {
            clients = new List<Client>();
        }
    }
}