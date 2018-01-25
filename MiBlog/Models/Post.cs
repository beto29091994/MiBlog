using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiBlog.Models
{
    public class Post
    {
        public int ID { get; set; }
        public int BlogID { get; set; }
        public string Text { get; set; }
        public DateTime PublicationDate { get; set; }

        public virtual Blog Blog { get; set; }
    }
}