using FBWTracker.Models;
using FBWTracker.ViewModels;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FBWTracker.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [DesignTimeVisible(false)]
    public partial class AddTrainingPage : ContentPage
    {
        TrainingDetail viewModel;
        public event PropertyChangedEventHandler PropertyChanged;

        public AddTrainingPage(TrainingDetail lastTraining)
        {

            InitializeComponent();
            BindingContext = viewModel = CreateViewModel(lastTraining);
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
        }

        async void OnSaveClicked(object sender, EventArgs e)
        {
            var training = (TrainingDetail)BindingContext;
            training.ID = Guid.NewGuid();
            var result = await App.Database.SaveTrainingAsync(training);
            await Navigation.PushModalAsync(new NavigationPage(new TrainingsListPage ()));
        }

        async void OnDeleteClicked(object sender, EventArgs e)
        {
            var todoItem = (TrainingDetail)BindingContext;
            await App.Database.DeleteTrainingAsync(todoItem);
            await Navigation.PopAsync();
        }

        async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new TrainingsListPage()));
        }

        TrainingDetail CreateViewModel(TrainingDetail estimatedTraining)
        {
            return new TrainingDetail
            {
                ID = Guid.NewGuid(),
                Date = DateTime.Now,
                TrainingA = estimatedTraining.TrainingA,
                Done = estimatedTraining.Done,
                Comment = estimatedTraining.Comment,
                //Exercises
                SquatsKG = estimatedTraining.SquatsKG + 5,
                SquatsS = estimatedTraining.SquatsS,
                SquatsQ = estimatedTraining.SquatsQ,

                DeadlifKG = estimatedTraining.DeadlifKG + 5,
                DeadliftS = estimatedTraining.DeadliftS,
                DeadliftQ = estimatedTraining.DeadliftQ,
                //wyciskanie leżąc
                BarbellPressKG = estimatedTraining.BarbellPressKG + 2.5,
                BarbellPressS = estimatedTraining.BarbellPressS,
                BarbellPressQ = estimatedTraining.BarbellPressQ,
                //zołnierskie
                OHPKG = estimatedTraining.OHPKG + 2.5,
                OHPS = estimatedTraining.OHPS,
                OHPQ = estimatedTraining.OHPQ,
                //Wiosłowanie
                BORKG = estimatedTraining.BORKG + 2.5,
                BORS = estimatedTraining.BORS,
                BORQ = estimatedTraining.BORQ,
                //waskie podciaganie
                CChinUpKG = estimatedTraining.CChinUpKG + 2.5,
                CChinUpS = estimatedTraining.CChinUpS,
                CChinUpQ = estimatedTraining.CChinUpQ,

                //barki bokiem
                DLRKG = estimatedTraining.DLRKG + 2.5,
                DLRS = estimatedTraining.DLRS,
                DLRQ = estimatedTraining.DLRQ,

                CBarbellPressKG = estimatedTraining.CBarbellPressKG + 2.5,
                CBarbellPressS = estimatedTraining.CBarbellPressS,
                CBarbellPressQ = estimatedTraining.CBarbellPressQ,

                BicTricKG = estimatedTraining.BicTricKG + 2.5,
                BicTricS = estimatedTraining.BicTricS,
                BicTricQ = estimatedTraining.BicTricQ,

                BicKG = estimatedTraining.BicKG + 2.5,
                BicS = estimatedTraining.BicS,
                BicQ = estimatedTraining.BicQ,

                AllahsKG = estimatedTraining.AllahsKG + 2.5,
                AllahsS = estimatedTraining.AllahsS,
                AllahsQ = estimatedTraining.AllahsQ,


                PlankSeconds = estimatedTraining.PlankSeconds,
                PlankS = estimatedTraining.PlankS,

                CalfKG = estimatedTraining.CalfKG + 2.5,
                CalfS = estimatedTraining.CalfS,
                CalfQ = estimatedTraining.CalfQ,
            };
        }
    }
}
