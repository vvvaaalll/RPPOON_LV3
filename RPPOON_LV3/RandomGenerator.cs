using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV3
{
        class RandomGenerator
        {
            private static RandomGenerator instance;
            private Random generator;
            private RandomGenerator()
            {
                this.generator = new Random();
            }
            public static RandomGenerator GetInstance()
            {
                if (instance == null)
                {
                    instance = new RandomGenerator();
                }
                return instance;
            }


        /*
         Singleton sadrži instancu svoje klase, što omogućuje korištenje te instance klase, bez nepotrebnog stvaranja novih
         RandomGenerator sadrži metodu koja vraća instancu klase(ukoliko ona još nije kreirana stvara novu), defaultni konstruktor
         te metodu za kreiranje matrica m*n dimenzija
             */


            public double[ , ] NextDouble(int m, int n)
            {

            double[,] matrix = new double[m,n];


            for (int i = 0; i < m; i++) 
            {
                for (int j = 0; j < n; j++) 
                {
                    matrix[i, j] = generator.NextDouble();
                                        
                }
                    
            
            }

            return matrix;

            }
           
        }


    
}
