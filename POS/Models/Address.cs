using POS.Models.Base;


namespace POS.Models
{

    public class Address : BaseEntity
    {
        public string Name { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Code { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Comments { get; set; }

        public int AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
    }

}