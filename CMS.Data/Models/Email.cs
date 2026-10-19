using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Data.Models
{
    public class Email
    {
        public int Id { get; set; }
        public string Subject { get; set; } 
        public string Body { get; set; } 
        public DateTime SendAt { get; set; }
        public string USerId { get; set; }
        public User User { get; set; }
    }
}
