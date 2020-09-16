using System.Collections.Generic;
using POS.Models.Base;


namespace POS.Models
{

    public class Blood : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<AppUser> Bloods { get; set; }
    }

}