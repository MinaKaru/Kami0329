using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blood
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] BloodType = { "O", "其他", "O", "O", "A", "O", "A", "A", "O", "O", "A", "O", "A", "B", "O", "O", "A", "其他", "O", "O", "A", "", "B", "O", "", "O", "B", "O", "B", "B", "B", "O", "O", "AB", "O", "B", "A", "O", "O", "", "O", "A", "", "O", "O", "A", "O", "O", "其他", "B", "O", "O", "O", "A", "AB", "A", "O", "B", "AB", "", "O", "O", "O", "", "O", "A", "A", "O" };

            int TypeA = 0;
            int TypeB = 0;
            int TypeO = 0;
            int TypeAB = 0;
            int TypeElse = 0;

            for (int i = 1; i < BloodType.Length; i++)
            {
                if (BloodType[i] == "O")
                {
                    TypeO++;
                }

                else if (BloodType[i] == "A")
                {
                    TypeA++;
                }

                else if (BloodType[i] == "B")
                {
                    TypeB++;
                }

                else if (BloodType[i] == "AB")
                {
                    TypeAB++;
                }

                else
                {
                    TypeElse++;
                }

            }
            double typeOp = (double)TypeO / (double)68;
            double typeAp = (double)TypeA / (double)68;     
            double typeBp = (double)TypeB / (double)68;
            double typeABp = (double)TypeAB / (double)68;
            double typeEp = (double)TypeElse / (double)68;

            Console.WriteLine("A型:" + TypeA.ToString() + "占全班比例:" + typeAp);
            Console.WriteLine("");
            Console.WriteLine("B型:" + TypeB.ToString() + "占全班比例:" + typeBp);
            Console.WriteLine("");
            Console.WriteLine("AB型:" + TypeAB.ToString() + "占全班比例:" + typeABp);
            Console.WriteLine("");
            Console.WriteLine("O型:" + TypeO.ToString() + "占全班比例:" + typeOp);
            Console.WriteLine("");
            Console.WriteLine("其他:" + TypeElse.ToString() + "占全班比例:" + typeEp);
            Console.WriteLine("");


            string[] Gender = { "男", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "男", "女", "男", "男", "男", "女", "女", "男", "男", "女", "男", "女", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "女", "男", "男", "女", "女", "男", "男", "女", "女", "男", "男", "男", "男", "男", "男", "女", "男", "女", "女", "女", "女", "女", "女", "男", "女", "女", "女", "女", "女", "男", "男", "女", "女", "女", "男" };
            int[] CM = { 173, 0, 179, 155, 183, 170, 163, 174, 165, 189, 177, 180, 154, 167, 170, 173, 165, 158, 180, 165, 153, 175, 162, 165, 0, 160, 165, 173, 164, 177, 177, 180, 170, 151, 176, 180, 168, 152, 666, 2147483647, 165, 155, 777, 173, 169, 170, 169, 171, 0, 170, 150, 160, 155, 164, 163, 165, 184, 165, 155, 0, 168, 160, 169, 0, 150, 163, 168, 173 };

            int GirlCM = 0;
            for (int a = 0; a < Gender.Length; a++)
            {
                if (Gender[a] == "女")
                {
                    GirlCM += CM[a];
                }
            }
            Console.WriteLine("女生身高:" + GirlCM);
            Console.Read();
        }
    }
}
