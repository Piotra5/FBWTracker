using FBWTracker.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FBWTracker.Services
{
    public class FBWDataStore : ITrainingDataStore<TrainingDetail>
    {
        readonly List<TrainingDetail> trainings;

        public FBWDataStore()
        {
            
        }


            public Task<bool> AddTrainingAsync(TrainingDetail item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteTrainingAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TrainingDetail>> GetDataAsync(bool forceRefresh = false)
        {
            throw new NotImplementedException();
        }

        public Task<TrainingDetail> GetTrainingAsync(string id)
        {
            throw new NotImplementedException();
        }
        
        public Task<TrainingDetail> GetLastABTrainingAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateTrainingAsync(TrainingDetail item)
        {
            throw new NotImplementedException();
        }
    }
}
