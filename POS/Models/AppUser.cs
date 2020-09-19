using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using POS.Models.Base;


namespace POS.Models
{

    public class AppUser : BaseEntity
    {
        [Required] public string NickName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get => FirstName + " " + LastName;
        }

        public virtual Image Avatar { get; set; }

        public int BloodId { get; set; }
        public virtual Blood Blood { get; set; }

        public int RankId { get; set; }
        public virtual Rank Rank { get; set; }

        //many-to-one
        public virtual ICollection<News> Newses { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }

        //many-to-many
        public virtual ICollection<CMSPage> CmsPages { get; set; }
        public virtual ICollection<GamesGroup> GamesGroups { get; set; }
    }

}