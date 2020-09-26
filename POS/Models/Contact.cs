using System.ComponentModel.DataAnnotations;
using POS.Models.Base;


namespace POS.Models
{

    public class Contact : BaseEntity
    {
        [Required(ErrorMessage = "Pole 'KONTAKT' nie może być puste!")]
        public string ContactInformation { get; set; }

        public int ContactTypeId { get; set; }
        public ContactType ContactType { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }

}