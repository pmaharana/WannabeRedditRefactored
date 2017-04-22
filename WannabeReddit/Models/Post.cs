using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WannabeReddit.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int? UpVotes { get; set; }
        public int? DownVotes { get; set; }
        public DateTime? DatePosted { get; set; } = DateTime.Now;

        public int? UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}