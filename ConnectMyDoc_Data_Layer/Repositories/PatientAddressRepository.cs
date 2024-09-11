using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectMyDoc_Data_Layer.Context;
using ConnectMyDoc_Domain_Layer.Entity;
using ConnectMyDoc_Domain_Layer.Repository;

namespace ConnectMyDoc_Data_Layer.Repositories
{
    public class PatientAddressRepository : IPatientAddressRepository
    {
        private readonly PatientCMDDbContext _dbContext = null;
        public PatientAddressRepository(PatientCMDDbContext db)
        {
            this._dbContext = db;
        }
        public Task<PatientAddress> AddPatientAddress(PatientAddress patientAddress)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletePatientAddress(int patientId)
        {
            throw new NotImplementedException();
        }

        public Task<PatientAddress> GetPatientAddress(int patientId)
        {
            throw new NotImplementedException();
        }

        public Task<PatientAddress> UpdatePatientAddress(int patientId, PatientAddress patientAddress)
        {
            throw new NotImplementedException();
        }
    }
}
