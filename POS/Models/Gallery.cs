using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using POS.Models.Base;


namespace POS.Models
{

    public class Gallery : BaseEntity
    {
        [Required(ErrorMessage = "Pole 'Tytuł' nie może być puste!")]
        public string Name { get; set; }
        public ICollection<Image> Images { get; set; }
    }

}