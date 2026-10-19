using CMS.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Data.Models
{
    public class Track : BaseEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int TimeInMinute { get; set; }
        public string TrackUrl { get; set; }
        public string OwnerName { get; set; }
        public string PublishedById { get;set; }
        public User PublishedBy { get; set; }
        public ContentStatus Status { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
