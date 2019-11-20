using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using FBWTracker.Models;
using FBWTracker.Views;
using FBWTracker.Data;

namespace FBWTracker.ViewModels
{
    public class DataViewModel : BaseViewModel
    {
        public ObservableCollection<TrainingDetail> Trainings { get; set; }
        public Command LoadItemsCommand { get; set; }

        public DataViewModel()
        {
            Title = "FBW Trainings";
            Trainings = new ObservableCollection<TrainingDetail>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            //MessagingCenter.Subscribe<NewItemPage, Item>(this, "AddItem", async (obj, item) =>
            //{
            //    var newItem = item as Item;
            //    Items.Add(newItem);
            //    await DataStore.AddItemAsync(newItem);
            //});
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Trainings.Clear();
                var trainings = await App.Database.GetTrainingsAsync();
                foreach (var t in trainings)
                {
                    Trainings.Add(t);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}