using System;
using System.ComponentModel.DataAnnotations;

namespace Forum.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime Created { get; set; }

        [Required]
        public string Author { get; set; }
    }
}