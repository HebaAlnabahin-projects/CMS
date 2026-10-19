using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Data.Models
{
    public class Advertisement : BaseEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string WebsiteUrl { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
        public string OwnerId { get; set; }
        public User Owner { get; set; }
    }
}
