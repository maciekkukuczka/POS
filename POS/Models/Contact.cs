using POS.Models.Base;


namespace POS.Models
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