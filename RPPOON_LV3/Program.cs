using System;

namespace RPPOON_LV3
{   
    class Program
    {
        static void Main(string[] args)
        {
            Dataset firstDataSet = new Dataset("CSV.txt");
            Dataset firstDataSetClone = (Dataset)firstDataSet.Clone();

            
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
