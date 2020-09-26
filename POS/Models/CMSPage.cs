using System.Collections.Generic;
using POS.Models.Base;


namespace POS.Models
{

    public class CMSPage : BaseEntity
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public string AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }

        public virtual ICollection<Image> Images { get; set; }
    }

}