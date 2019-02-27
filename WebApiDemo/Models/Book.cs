using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApiDemo.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Title { get; set; }

        [MaxLength(50)]
        [Required]
        public string Author { get; set; }
        [Required]
        public int PublicationYear { get; set; }
    }
}