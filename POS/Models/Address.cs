using System.ComponentModel.DataAnnotations;
using POS.Models.Base;


namespace POS.Models
{

    public class Address : BaseEntity
    {
        [Required(ErrorMessage = "Pole 'NAZWA ADRESU' jest wymagana")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Pole 'ULICA' jest wymagana")]
        public string Line1 { get; set; }

        public string Line2 { get; set; }

        [Required(ErrorMessage = "Pole 'KOD' jest wymagana")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Pole 'MIASTO' jest wymagana")]
        public string City { get; set; }

        public string Country { get; set; }

        public string Comments { get; set; }

        public string AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
    }

}