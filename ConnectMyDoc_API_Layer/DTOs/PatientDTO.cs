using ConnectMyDoc_Domain_Layer.Entity;
using ConnectMyDoc_Domain_Layer.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ConnectMyDoc_API_Layer.DTOs
{
    public class PatientDTO
    {
        [Required]
        [Key]
        public int PatientId { get; set; }

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
        [Range(0,150)]
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
        public int CreatedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public int LastModifiedBy { get; set; }
        public string Status { get; set; }
        public Clinic? PreferredClinic { get; set; }
        //For image
        public byte[]? Image { get; set; }
        public int? PatientAddressId { get; set; }
        public PatientAddress? PatientAddress { get; set; }
        public int DoctorId { get; set; }
    }
}
