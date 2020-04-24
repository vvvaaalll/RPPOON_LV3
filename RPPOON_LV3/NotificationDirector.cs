using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV3
{
    class NotificationDirector
    {

        public ConsoleNotification AlertNotification(string author)
        {
            return new ConsoleNotification(author, "Naslov", "Defaultni tekst obavijesti", DateTime.Now, Category.ALERT, ConsoleColor.Cyan);
          
        }

        public ConsoleNotification InfoNotification(string author)
        {
            return new ConsoleNotification(author, "Naslov", "Defaultni tekst obavijesti", DateTime.Now, Category.INFO, ConsoleColor.Cyan);

        }

        public ConsoleNotification ErrorNotification(string author)
        {
            return new ConsoleNotification(author, "Naslov", "Defaultni tekst obavijesti", DateTime.Now, Category.ERROR, ConsoleColor.Cyan);

        }

    }
}
