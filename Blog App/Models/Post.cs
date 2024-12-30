
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Blog_App.Models;

namespace Blog_App.Models
{
    public class Post
    {
        public int PostId { get; set; }

        [Required(ErrorMessage ="Title is requierd")]
        [StringLength(100)]
        public string Title { get; set; }

        [Required(ErrorMessage ="Content is requierd")]
        public string Content {  get; set; }
        public  DateTime CreatedDate {  get; set; }
        public string Author {  get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}