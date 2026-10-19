using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Data.Models
{
    public class Category : BaseEntity
    {
        public int id { get; set; }
        public string Name { get; set; }
        public List<Post> Posts { get; set; }
        public List<Track> Tracks { get; set; }
    }
}
