using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tall
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] Tall = { 173, 0, 179, 155, 183, 170, 163, 174, 165, 189, 177, 180, 154, 167, 170, 173, 165, 158, 180, 165, 153, 175, 162, 165, 0, 160, 165, 173, 164, 177, 177, 180, 170, 151, 176, 180, 168, 152, 666, 2147483647, 165, 155, 777, 173, 169, 170, 169, 171, 0, 170, 150, 160, 155, 164, 163, 165, 184, 165, 155, 0, 168, 160, 169, 0, 150, 163, 168, 173 };

            int Min = -99999;

            for (int i=0 ; i > Tall.Length; i++)
            {
                if (Tall[i] > 100 && Tall[i] < 200)
                {
                    Min = Tall[i];
                }
            }
            Console.WriteLine("班上最矮身高為:" + Min);   
            Console.ReadLine();
        }
    }
}
