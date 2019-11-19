using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FBWTracker.Services
{
    public interface IDataStore<T>
    {
        Task<bool> AddTrainingAsync(T item);
        Task<bool> UpdateTrainingAsync(T item);
        Task<bool> DeleteTrainingAsync(string id);
        Task<T> GetTrainingAsync(string id);
        Task<IEnumerable<T>> GetDataAsync(bool forceRefresh = false);
    }
}
