using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV3
{
    class Dataset : IPrototype
    {
        private List<List<string>> data; //list of lists of strings
        public Dataset()
        {
            this.data = new List<List<string>>();
        }
        public Dataset(string filePath) : this()
        {
            this.LoadDataFromCSV(filePath);
        }
        public void LoadDataFromCSV(string filePath)
        {
            using (System.IO.StreamReader reader = new System.IO.StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    List<string> row = new List<string>();
                    string[] items = line.Split(',');
                    foreach (string item in items)
                    {
                        row.Add(item);
                    }
                    this.data.Add(row);
                }
            }
        }
        public IList<List<string>> GetData()
        {
            return
           new System.Collections.ObjectModel.ReadOnlyCollection<List<string>>(data);
        }
        public void ClearData()
        {
            this.data.Clear();
        }

        public IPrototype Clone()
        {

            /*u danom primjeru razlike između dubokog i plitkog kopiranja gotovo nema obzirom da nemamo metodu kojom možemo
             mijenjati objekte klase. dodamo li setter i koristimo plitko kopiranje nastat će problem jer će se, pri izmjeni jednog objekta, mijenjati oba,
             obzirom da im je referenca na istom podatku. Također koristimo li plitko kopiranje i pozovemo meodu Clear, koja briše sve elemente liste
             obrisat će nam se oba objekta. Stoga je i dalje preporučljivo koristiti duboko kopiranje*/

            // return (Prototype)this.MemberwiseClone();    //shallow copy

            Dataset clone = new Dataset();

            for (int i = 0; i < data.Count; i++)
            {
                clone.data.Add(new List<string>());
                for (int j = 0; j < data[i].Count; j++)
                {
                    clone.data[i].Add(data[i][j]);
                }
            }

            return clone;

        }

  

        //public void SetData(int i, int j, string value)
        //{
        //    data[i][j] = value;
        //}



    }



}
