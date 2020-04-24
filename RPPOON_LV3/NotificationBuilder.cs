using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV3
{
    class NotificationBuilder : IBuilder
    {
        public String author = "Valentin Loboda";
        public String title = "naslov";
        public String text = "ovo bi bila neka defaultna obavijest";
        public DateTime timestamp = DateTime.Now;
        public Category level = Category.INFO;
        public ConsoleColor color = ConsoleColor.Green;

      

        public ConsoleNotification Build()
        {
            return new ConsoleNotification(author, title, text, timestamp, level, color); 
        }

        public IBuilder SetAuthor(string author)
        {
            this.author = author;
            return this;
        }

        public IBuilder SetColor(ConsoleColor color)
        {
            this.color = color;
            return this;
        }

        public IBuilder SetLevel(Category level)
        {
            this.level = level;
            return this;
        }

        public IBuilder SetText(string text)
        {
            this.text = text;
            return this;
        }

        public IBuilder SetTime(DateTime time)
        {
            this.timestamp = time;
            return this;
        }

        public IBuilder SetTitle(string title)
        {
            this.title = title;
            return this;
        }
    }
}
