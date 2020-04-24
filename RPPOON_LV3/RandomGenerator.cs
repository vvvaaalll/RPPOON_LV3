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
            public int[ , ] NextInt(int m, int n)
            {

            int[,] matrix = new int[m,n];


            for (int i = 0; i < m; i++) 
            {
                for (int j = 0; j < n; j++) 
                {
                    matrix[i, j] = generator.Next(1 ,5);
                                        
                }
                    
            
            }



            return matrix;

            }
           
        }


    
}
