using System.Collections.Generic;
using POS.Models.Base;


namespace POS.Models
{

    public class GamesGroup : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<AppUser> AppUsers { get; set; }
        public virtual ICollection<BlogPost> BlogPosts { get; set; }
    }

}