using System.Collections.Generic;
using POS.Models.Base;


namespace POS.Models
{

    public class Rank : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<AppUser> AppUsers { get; set; }
    }

}