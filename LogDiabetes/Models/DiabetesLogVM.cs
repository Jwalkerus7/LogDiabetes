﻿using LogDiabetes.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace LogDiabetes.Models
{
    public class DiabetesLogVM
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string Before_Meal_Test { get; set; }
        public string Meal_BK_L_D_S { get; set; }
        public string What_Was_Eaten { get; set; }
        public string Hours_After_Meal_Test { get; set; }

        public DiabetesLogVM() { }

        public DiabetesLogVM(Log_Diabetes DL) 
        {
            this.ID = DL.ID;
            this.Date = DL.Date;
            this.Before_Meal_Test = DL.Before_Meal_Test;
            this.Meal_BK_L_D_S = DL.Meal_BK_L_D_S;
            this.What_Was_Eaten = DL.What_Was_Eaten;
            this.Hours_After_Meal_Test = DL.Hours_After_Meal_Test;
        }
    }
}