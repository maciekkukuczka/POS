namespace POS.Models.Base
{

    public class BaseEntity
    {
        public int Id { get; set; }
        public string Class { get; set; }
        public bool IsActive { get; set; } = true;
    }

}