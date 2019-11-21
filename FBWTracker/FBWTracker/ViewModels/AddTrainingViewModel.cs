//using System;

//using FBWTracker.Models;

//namespace FBWTracker.ViewModels
//{
//    public class AddTrainingViewModel : BaseViewModel
//    {
//        var estimatedTraining = new TrainingDetail();

//        public AddTrainingViewModel(TrainingDetail lastTraining)
//        {
//            estimatedTraining = lastTraining;
//            Date = DateTime.Now;
//        }

//        public string Date { get; set; }
//        public DateTime? TrainingDate { get; set; }
//        public bool TrainingA { get; set; } = estimatedTraining.TrainingA;
//        public bool Done { get; set; } = estimatedTraining.Done;
//        public string Comment { get; set; } = estimatedTraining.Comment;


//        //Exercises
//        public double? SquatsKG { get; set; } = estimatedTraining.SquatsKG + 5;
//        public int? SquatsS { get; set; } = estimatedTraining.SquatsS;
//        public int? SquatsQ { get; set; } = estimatedTraining.SquatsQ;

//        public double? DeadlifKG { get; set; } = estimatedTraining.DeadlifKG + 5;
//        public int? DeadliftS { get; set; } = estimatedTraining.DeadliftS;
//        public int? DeadliftQ { get; set; } = estimatedTraining.DeadliftQ;
//        //wyciskanie leżąc
//        public double? BarbellPressG { get; set; } = estimatedTraining.BarbellPressG + 2.5;
//        public int? BarbellPressS { get; set; } = estimatedTraining.BarbellPressS;
//        public int? BarbellPressQ { get; set; } = estimatedTraining.BarbellPressQ;
//        //zołnierskie
//        public double? OHPKG { get; set; } = estimatedTraining.OHPKG + 2.5;
//        public int OHPS { get; set; } = estimatedTraining.OHPS;
//        public int? OHPQ { get; set; } = estimatedTraining.OHPQ;
//        //Wiosłowanie
//        public double? BORKG { get; set; } = estimatedTraining.BORKG + 2.5;
//        public int? BORS { get; set; } = estimatedTraining.BORS;
//        public int? BORQ { get; set; } = estimatedTraining.BORQ;
//        //waskie podciaganie
//        public double? CChinUpKG { get; set; } = estimatedTraining.CChinUpKG + 2.5;
//        public int? CChinUpS { get; set; } = estimatedTraining.CChinUpS;
//        public int? CChinUpQ { get; set; } = estimatedTraining.CChinUpQ;

//        //barki bokiem
//        public double? DLRG { get; set; } = estimatedTraining.DLRG + 2.5;
//        public int? DLRS { get; set; } = estimatedTraining.DLRS;
//        public int? DLRQ { get; set; } = estimatedTraining.DLRQ;

//        public double? CBarbellPressKG { get; set; } = estimatedTraining.CBarbellPressKG + 2.5;
//        public int? CBarbellPressS { get; set; } = estimatedTraining.CBarbellPressS;
//        public int? CBarbellPressQ { get; set; } = estimatedTraining.CBarbellPressQ;

//        public double? BicTricKG { get; set; } = estimatedTraining.BicTricKG + 2.5;
//        public int? BicTricS { get; set; } = estimatedTraining.BicTricS;
//        public int? BicTricQ { get; set; } = estimatedTraining.BicTricQ;

//        public double? BicKG { get; set; } = estimatedTraining.BicKG + 2.5;
//        public int? BicS { get; set; } = estimatedTraining.BicS;
//        public int? BicQ { get; set; } = estimatedTraining.BicQ;

//        public double? AllahsG { get; set; } = estimatedTraining.AllahsG + 2.5;
//        public int? AllahsS { get; set; } = estimatedTraining.AllahsS;
//        public int? AllahsQ { get; set; } = estimatedTraining.AllahsQ;


//        public int? PlankSeconds { get; set; }
//        public int? PlankS { get; set; }

//        public double? CalfKG { get; set; }
//        public int? CalfS { get; set; }
//        public int? CalfQ { get; set; }

//        public AddTrainingViewModel()
//        {
//        }
//    }
//}
