using ConnectMyDoc_Domain_Layer.Repository;

namespace ConnectMyDoc_API_Layer.Services
{
    public class PatientService
    {
        private readonly IPatientRepository patientRepository = null;
        public PatientService(IPatientRepository repo)
        {
            patientRepository = repo;
        }
    }
}
