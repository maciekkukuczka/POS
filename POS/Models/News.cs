using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using POS.Models.Base;


namespace POS.Models
{

    public class News : BaseEntity
    {
        public bool IsVisible { get; set; }
        [Required(ErrorMessage = "Pole TYTUŁ jest wymagane!")]
        [StringLength(100, ErrorMessage = "Pole jest za długie!")]
        public string Title { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string Content { get; set; }

        public int AppUserID { get; set; }
        [Required(ErrorMessage = "Pole 'AUTOR' jest wymagane!")]
        [ValidateComplexType]
        public virtual AppUser AppUser { get; set; }

        [Required]

        // [Range(typeof(bool), "false","true")]
        [ValidateComplexType]
        public virtual ICollection<GamesGroup> GamesGroups { get; set; }
        public virtual ICollection<Image> Images { get; set; }
    }

}