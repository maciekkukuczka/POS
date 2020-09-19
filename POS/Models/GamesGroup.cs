using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using POS.Models.Base;


namespace POS.Models
{

    public class GamesGroup : BaseEntity
    {
        [Required] public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<AppUser> AppUsers { get; set; }
        public virtual ICollection<News> Newses { get; set; }
    }

}