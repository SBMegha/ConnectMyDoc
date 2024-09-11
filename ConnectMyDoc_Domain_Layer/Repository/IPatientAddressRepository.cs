using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectMyDoc_Domain_Layer.Entity;

namespace ConnectMyDoc_Domain_Layer.Repository
{
    public interface IPatientAddressRepository
    {
        //Admin, user(patient)
        Task<PatientAddress> AddPatientAddress(PatientAddress patientAddress);
        Task<PatientAddress> UpdatePatientAddress(int patientId, PatientAddress patientAddress);
        Task<PatientAddress> GetPatientAddress(int patientId);

        //Admin( if admin deletes patient, the address deleted on cascaded), This method is not required ..
        Task<bool> DeletePatientAddress(int patientId);
        
    }
}
