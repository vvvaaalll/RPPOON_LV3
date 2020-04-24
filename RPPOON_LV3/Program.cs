using System;

namespace RPPOON_LV3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dataset firstDataSet = new Dataset("CSV.txt");
            Dataset firstDataSetClone = (Dataset)firstDataSet.Clone();

            firstDataSet.PrintToConsole();
       //     firstDataSetClone.SetData(1, 3, " h");
            firstDataSetClone.PrintToConsole();

            firstDataSet.PrintToConsole();
            firstDataSetClone.PrintToConsole();

            firstDataSet.ClearData();

            firstDataSet.PrintToConsole();
            firstDataSetClone.PrintToConsole();
        }
    }
}
