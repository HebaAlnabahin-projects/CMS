using System;
using System.Collections.Generic;
using System.Text;
using CMS.Core.Enums;
using Microsoft.AspNetCore.Identity;

namespace CMS.Data.Models
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }
        public DateTime? DOB { get; set; }
        public string ImageUrl { get; set; }
        public bool IsDelete { get; set; }
        public UserType UserType { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public List<Post> Posts { get; set; }
        public List<Track> Tracks { get; set; } 
        public List<Advertisement> Advertisements { get; set; } 
        public List<Email> Emails { get; set; }
        public List<Notification> Notifications { get; set; }
    }
}
