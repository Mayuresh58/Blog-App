using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog_App.Models
{
    public class Comment
    {
        public int CommentId {  get; set; }
        public int PostId {  get; set; }
        public string Content {  get; set; }
        public DateTime PostedDate { get; set; }
        public string  Commenter { get; set; }
    }
}