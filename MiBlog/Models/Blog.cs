using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiBlog.Models
{
    public class Blog
    {
        public int ID { get; set; }
        public string Author { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}