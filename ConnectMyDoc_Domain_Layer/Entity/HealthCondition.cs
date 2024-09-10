
namespace ConnectMyDoc_Domain_Layer.Entity
{
    public class HealthCondition
    {
        public long HealthConditionId { get; set; } //Id of Patient Health Condition 
        public string Condition { get; set; } //Health condition of Patient 
        public DateTime CreatedDate { get; set; } //Date when Patient condition was created 
        public long CreatedBy { get; set; } //Id of person who created Patient condition 
        public DateTime LastModifiedDate { get; set; } //Date when Patient data was modified last time 
        public long LastModifiedBy { get; set; } //Id of Person who modified Patient Last time 
    }
}
