using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FBWTracker.Models
{
    public class TrainingDetail
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public bool Done { get; set; }
        public string Comment { get; set; }


        //Exercises
        public float SquatsKG { get; set; }
        public int SquatsS { get; set; }
        public int SquatsQ { get; set; }

        public float DeadlifKG { get; set; }
        public int DeadliftS { get; set; }
        public int DeadliftQ { get; set; }
        //wyciskanie leżąc
        public float BarbellPressG { get; set; }
        public int BarbellPressS { get; set; }
        public int BarbellPressQ { get; set; }
        //zołnierskie
        public float OHPKG { get; set; }
        public int OHPS { get; set; }
        public int OHPQ { get; set; }
        //Wiosłowanie
        public float BORKG { get; set; }
        public int BORS { get; set; }
        public int BORQ { get; set; }
        //waskie podciaganie
        public float CChinUpKG { get; set; }
        public int CChinUpS { get; set; }
        public int CChinUpQ { get; set; }

        //barki bokiem
        public float DLRG { get; set; }
        public int DLRS { get; set; }
        public int DLRQ { get; set; }

        public float CBarbellPressKG { get; set; }
        public int CBarbellPressS { get; set; }
        public int CBarbellPressQ { get; set; }

        public float BicTricKG { get; set; }
        public int BicTricS { get; set; }
        public int BicTricQ { get; set; }

        public float BicKG { get; set; }
        public int BicS { get; set; }
        public int BicQ { get; set; }

        public float AllahsG { get; set; }
        public int AllahsS { get; set; }
        public int AllahsQ { get; set; }

        public float PlankKG { get; set; }
        public int PlankS { get; set; }

        public float CalfKG { get; set; }
        public int CalfS { get; set; }
        public int CalfQ { get; set; }
    }
}
