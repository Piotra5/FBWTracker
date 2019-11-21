﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using FBWTracker.Models;
using FBWTracker.Views;
using FBWTracker.ViewModels;

namespace FBWTracker.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class TrainingsListPage : ContentPage
    {
        DataViewModel viewModel;

        public TrainingsListPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new DataViewModel();
        }

        //async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        //{
        //    var item = args.SelectedItem as Item;
        //    if (item == null)
        //        return;

        //    await Navigation.PushAsync(new ExDetailPage(new ItemDetailViewModel(item)));

        //    // Manually deselect item.
        //    ItemsListView.SelectedItem = null;
        //}

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            var lastTraining = await App.Database.GetLastTrainingABAsync();
            if (lastTraining == null)
            {
                lastTraining = new TrainingDetail();
            }
            await Navigation.PushModalAsync(new NavigationPage(new AddTrainingPage(lastTraining)));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Trainings.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}