using ConnectMyDoc_Data_Layer.Context;
using ConnectMyDoc_Domain_Layer.Repository;

namespace ConnectMyDoc_API_Layer.Services
{
    public class PatientAddressService
    {
        private readonly IPatientAddressRepository patientAddressRepository = null;
        public PatientAddressService(IPatientAddressRepository repo)
        {
            patientAddressRepository = repo;
        }
    }
}
