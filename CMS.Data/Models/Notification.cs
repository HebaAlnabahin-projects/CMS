using CMS.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Data.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public NotificationAction Action { get; set; }
        public string ActionId { get; set; }
        public DateTime SendAt { get; set; }
        public string USerId { get; set; }
        public User User { get; set; }
    }
}
