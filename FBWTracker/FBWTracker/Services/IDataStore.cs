using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FBWTracker.Services
{
    public interface ITrainingDataStore<T>
    {
        Task<bool> AddTrainingAsync(T item);
        Task<bool> UpdateTrainingAsync(T item);
        Task<bool> DeleteTrainingAsync(string id);
        Task<T> GetTrainingAsync(string id);
        Task<T> GetLastABTrainingAsync();
        Task<IEnumerable<T>> GetDataAsync(bool forceRefresh = false);
    }
}
