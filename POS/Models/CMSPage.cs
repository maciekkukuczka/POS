using System.Collections.Generic;
using POS.Models.Base;


namespace POS.Models
{

    public class CMSPage : BaseEntity
    {
        public string PageName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }

        public virtual ICollection<Image> Images { get; set; }
    }

}