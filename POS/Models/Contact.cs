using POS.Models;
using POS.Models.Base;


namespace POSMVC.Domain.Models
{

    public class Contact : BaseEntity
    {
        public string ContactInformation { get; set; }

        public int ContactTypeId { get; set; }
        public ContactType ContactType { get; set; }

        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }

}