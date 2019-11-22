using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FBWTracker.Models
{
    public class TrainingDetail
    {
        [PrimaryKey]
        public Guid ID { get; set; }
        public DateTime? Date { get; set; }
        public bool TrainingA { get; set; }
        public bool Done { get; set; }
        public string Comment { get; set; }


        //Exercises
        public double? SquatsKG { get; set; }
        public int? SquatsS { get; set; }
        public int? SquatsQ { get; set; }

        public double DeadlifKG { get; set; }
        public int? DeadliftS { get; set; }
        public int? DeadliftQ { get; set; }
        //wyciskanie leżąc
        public double BarbellPressKG { get; set; }
        public int? BarbellPressS { get; set; }
        public int? BarbellPressQ { get; set; }
        //zołnierskie
        public double OHPKG { get; set; }
        public int OHPS { get; set; }
        public int? OHPQ { get; set; }
        //Wiosłowanie
        public double BORKG { get; set; }
        public int? BORS { get; set; }
        public int? BORQ { get; set; }
        //waskie podciaganie
        public double CChinUpKG { get; set; }
        public int? CChinUpS { get; set; }
        public int? CChinUpQ { get; set; }

        //barki bokiem
        public double DLRKG { get; set; }
        public int? DLRS { get; set; }
        public int? DLRQ { get; set; }

        public double CBarbellPressKG { get; set; }
        public int? CBarbellPressS { get; set; }
        public int? CBarbellPressQ { get; set; }

        public double BicTricKG { get; set; }
        public int? BicTricS { get; set; }
        public int? BicTricQ { get; set; }

        public double BicKG { get; set; }
        public int? BicS { get; set; }
        public int? BicQ { get; set; }

        public double AllahsKG { get; set; }
        public int? AllahsS { get; set; }
        public int? AllahsQ { get; set; }

        public double PlankKG { get; set; }
        public int? PlankSeconds { get; set; }
        public int? PlankS { get; set; }

        public double CalfKG { get; set; }
        public int? CalfS { get; set; }
        public int? CalfQ { get; set; }
    }
}
