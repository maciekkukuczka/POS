using System;
using System.Collections.Generic;
using POS.Models.Base;


namespace POS.Models
{

    public class Image : BaseEntity
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public byte[] ImageDb { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;

        public int AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }

        public virtual ICollection<BlogPost> BlogPosts { get; set; }
        public virtual ICollection<CMSPage> CmsPages { get; set; }
    }

}