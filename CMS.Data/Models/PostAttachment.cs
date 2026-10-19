using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Data.Models
{
    public class PostAttachment
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
        public string AttachmentUrl { get; set; }
    }
}
