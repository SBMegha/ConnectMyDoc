
using System.ComponentModel.DataAnnotations;



namespace ConnectMyDoc_Domain_Layer.Entity
{
    public class PatientAddress
    {
        [Required]
        [Key]
        public long PatientAddressId { get; set; } //Id of Patient Address 

        public string StreetAddress { get; set; } //Street address of Patient

        public string City { get; set; } //City in which Patient is residing

        public string State { get; set; } //State in which Patient is residing 

        public string Country { get; set; } //Country in which Patient is residing

        public long ZipCode { get; set; } //Zipcode of area where Patient is residing

        public DateTime CreatedDate { get; set; } //Date when Patient Address was created

        public long CreatedBy { get; set; } //Id of person who created Patient Address 

        public DateTime LastModifiedDate { get; set; } //Date when Patient Address data was modified last time 

        public long LastModifiedBy { get; set; } //Id of Person who modified Patient Address Last time

    }
}
