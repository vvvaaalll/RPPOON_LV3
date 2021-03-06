﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV3
{
    public enum Category { ERROR, ALERT, INFO }

    public class ConsoleNotification : IPrototype
    {
        public String Author { get; private set; }
        public String Title { get; private set; }
        public String Text { get; private set; }
        public DateTime Timestamp { get; private set; }
        public Category Level { get; private set; }
        public ConsoleColor Color { get; private set; }


        public ConsoleNotification(String author, String title,
        String text, DateTime time, Category level, ConsoleColor color)
        {
            this.Author = author;
            this.Title = title;
            this.Text = text;
            this.Timestamp = time;
            this.Level = level;
            this.Color = color;
        }

        IPrototype IPrototype.Clone()
        {
            
                return (IPrototype)this.MemberwiseClone();
            
        }

        //u navedenom primjeru primjeru velika je razlika u korištenju dubokog i plitkog kopiranja obzirom da se svaka 
        //vrijednost/varijbla može mijenjati. čime bi kod plitkog kopiranja, promjenom vrijednosti u jednoj kopiji, mijenjaju se sve 
        // (obzirom da se referenciraju na isti podatak). dok kod dubokog kopiranja stvaramo potpuno nove podatke koje možemo odvojeno izmjenjivati


    }

}
