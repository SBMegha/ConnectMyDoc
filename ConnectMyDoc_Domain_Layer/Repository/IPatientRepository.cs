using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using ConnectMyDoc_Domain_Layer.Entity;
using ConnectMyDoc_Domain_Layer.Enums;

namespace ConnectMyDoc_Domain_Layer.Repository
{
    public interface IPatientRepository
    {
        //Admin and User(patient)
        Task<Patient> AddPatientAsync(Patient patient);

        //Admin, User(patient)
        Task<Patient> UpdatePatientAsync(Patient patient, int patientId);
        Task<bool> SetPrimaryDoctorAsync(int patientId, int doctorId);
        Task<bool> SetPrimaryClinicAsync(int patientId, Clinic clinic);

        //Doctor, Admin
        Task<Patient> GetPatientByIdAsync(int patientId);

        //Admin
        Task<List<Patient>> GetAllPatientsAsync(int pageNumber, int pageSize);
        Task<int> GetTotalPatientsCountAsync();

        //Admin
        Task<bool> DeletePatientAsync(int patientId);
    }
}
