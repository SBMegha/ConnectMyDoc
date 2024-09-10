
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ConnectMyDoc_Domain_Layer.Enums;


namespace ConnectMyDoc_Domain_Layer.Entity
{
    public class Patient
    {
        [Required]
        [Key]
        public long PatientId { get; set; }

        [Required]
        [MinLength(3)]
        public string PatientName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        [StringLength(10)]
        public string Phone { get; set; }
        [Required]
        public int Age { get; set; }

        [Required]
        public string Dob { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public DateTime PreferredStartTime { get; set; }
        [Required]
        public DateTime PreferredEndTime { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreatedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public long LastModifiedBy { get; set; }
        public string Status { get; set; }

        public Clinic? PreferredClinic { get; set; }

        //For image
        public byte[]? Image { get; set; }

        [Required]
        [ForeignKey(nameof(PatientAddress))]
        public long PatientAddressId { get; set; }
        public PatientAddress PatientAddress { get; set; }

        [Required]
        [ForeignKey(nameof(HealthCondition))]
        public long HealthConditionId { get; set; }
        public HealthCondition HealthCondition { get; set; }
    }
}
