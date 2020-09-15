using System;
using System.Collections.Generic;
using POS.Models.Base;


namespace POS.Models
{

    public class News : BaseEntity
    {
        public bool IsVisible { get; set; }

        // public byte[] Image { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }

        public int AppUserID { get; set; }
        public virtual AppUser AppUser { get; set; }

        public virtual ICollection<GamesGroup> GamesGroups { get; set; }
        public virtual ICollection<Image> Images { get; set; }
    }

}