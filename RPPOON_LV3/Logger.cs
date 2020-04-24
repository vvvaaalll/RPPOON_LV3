using System;
using System.Collections.Generic;
using System.Text;


namespace RPPOON_LV3
{
    class Logger
    {

        private static Logger instance;
        private string fileName;


        public Logger(string fileName)
        {

            this.fileName = fileName;

        }



        public static Logger GetInstance()
        {

            if (instance == null)
            {

                instance = new Logger("zad3.txt");

            }

            return instance;

        }


        public void ToFile(string text)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(this.fileName, true)) // zapisuje sve u datoteku, ne briše stari sadržaj
            {

                writer.WriteLine(text);

            }


        }

    }
}