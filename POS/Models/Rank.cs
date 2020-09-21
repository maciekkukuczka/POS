using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using POS.Models.Base;


namespace POS.Models
{

    public class Rank : BaseEntity
    {
        [Required(ErrorMessage = "Pole 'RANGA' nie może być puste")]
        public string Name { get; set; }

        public virtual ICollection<AppUser> AppUsers { get; set; }
    }

}