using System;

namespace RPPOON_LV3
{   
    class Program
    {
        static void Main(string[] args)
        {
            Dataset firstDataSet = new Dataset("CSV.txt");
            Dataset firstDataSetClone = (Dataset)firstDataSet.Clone();

            ConsoleNotification notification = new ConsoleNotification("Valentin Loboda", "Test, proba- 1, 2. 1, 2.",
      "neki tekst", DateTime.Now, Category.INFO, ConsoleColor.DarkCyan);

            NotificationManager manager = new NotificationManager();

            manager.Display(notification);


            //     firstDataSetClone.SetData(1, 3, " h");





            for (int i = 0; i < firstDataSetClone.GetData().Count; i++)
                {
                    for (int j = 0; j < firstDataSetClone.GetData()[i].Count; j++)
                    {
                        Console.Write(firstDataSetClone.GetData()[i][j]);
                    }
                    Console.WriteLine();
                }


                //provjera 3. zadatka

            Logger log = new Logger("zad3.txt");
            for (int i = 0; i < firstDataSetClone.GetData().Count; i++)
            {
                for (int j = 0; j < firstDataSetClone.GetData()[i].Count; j++)
                {
                    log.ToFile(firstDataSetClone.GetData()[i][j]);
                }
               
            }



        }
    }
}
