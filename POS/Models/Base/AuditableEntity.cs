using System;


namespace POS.Models.Base
{

    public class AuditableEntity : BaseEntity
    {
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int? ModifiedById { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
    }

}