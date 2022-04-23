namespace HRLeaveManagement.Domain.common
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }      
        public DateTime DateCreated { get; set; }
        public DateTime LastModifiedDateTime { get; set; }
    }
}
