using System.Collections.Generic;
using POS.Models.Base;


namespace POS.Models
{

    public class Gallery : BaseEntity
    {
        public string Name { get; set; }
        public bool IsVisible { get; set; }
        public ICollection<Image> Images { get; set; }
    }

}