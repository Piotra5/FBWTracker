using FBWTracker.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FBWTracker.Data
{
    public class TrackerDatabase
    {
        readonly SQLiteAsyncConnection database;

        public TrackerDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<TrainingDetail>().Wait();
        }

        public Task<List<TrainingDetail>> GetTrainingsAsync()
        {
            return database.Table<TrainingDetail>().ToListAsync();
        }

        public Task<List<TrainingDetail>> GetTrainingsNotDoneAsync()
        {
            return database.QueryAsync<TrainingDetail>("SELECT * FROM [TrainingDetails] WHERE [Done] = 0");
        }

        public Task<TrainingDetail> GetTrainingAsync(string id)
        {
            var guidID = new Guid(id);
            return database.Table<TrainingDetail>().Where(i => i.ID == guidID).FirstOrDefaultAsync();
        }

        public Task<TrainingDetail> GetLastTrainingABAsync()
        {

            return database.Table<TrainingDetail>().OrderByDescending(x => x.Date).Skip(1).
                FirstOrDefaultAsync();

        }

        public Task<int> SaveTrainingAsync(TrainingDetail item)
        {
            if (item.ID == null)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteTrainingAsync(TrainingDetail item)
        {
            return database.DeleteAsync(item);
        }
    }
}
