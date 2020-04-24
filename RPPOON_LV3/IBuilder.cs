﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV3
{
    interface IBuilder
    {
        ConsoleNotification Build();
        IBuilder SetAuthor(String author);
        IBuilder SetTitle(String title);
        IBuilder SetTime(DateTime time);
        IBuilder SetLevel(Category level);
        IBuilder SetColor(ConsoleColor color);
        IBuilder SetText(String text);

    }
}
