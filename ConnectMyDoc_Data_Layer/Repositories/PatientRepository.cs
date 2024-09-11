using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectMyDoc_Data_Layer.Context;
using ConnectMyDoc_Domain_Layer.Entity;
using ConnectMyDoc_Domain_Layer.Enums;
using ConnectMyDoc_Domain_Layer.Repository;

namespace ConnectMyDoc_Data_Layer.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private readonly PatientCMDDbContext _dbContext= null;
        public PatientRepository(PatientCMDDbContext db) 
        {
            _dbContext = db;
        }

        public Task<bool> ActivatePatientAsync(int patientId)
        {
            throw new NotImplementedException();
        }

        public Task<Patient> AddPatientAsync(Patient patient)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletePatientAsync(int patientId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Patient>> GetAllPatientsAsync(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<Patient> GetPatientByIdAsync(int patientId)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetTotalPatientsCountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> InActivatePatientAsync(int patientId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SetPrimaryClinicAsync(int patientId, Clinic clinic)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SetPrimaryDoctorAsync(int patientId, int doctorId)
        {
            throw new NotImplementedException();
        }

        public Task<Patient> UpdatePatientAsync(Patient patient, int patientId)
        {
            throw new NotImplementedException();
        }
    }
}
