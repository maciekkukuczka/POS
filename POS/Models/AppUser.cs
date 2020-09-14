using System.Collections.Generic;
using POS.Models.Base;
using POSMVC.Domain.Models;


namespace POS.Models
{

    public class AppUser : BaseEntity
    {
        public string NickName { get; set; }
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

        public virtual ICollection<BlogPost> BlogPosts { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }

        public virtual ICollection<CMSPage> CmsPages { get; set; }
        public virtual ICollection<GamesGroup> GamesGroups { get; set; }
    }

}