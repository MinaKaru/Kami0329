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
            string[] Names = { "葉俊廷", "張澤瑜", "王程捷 的咩？", "江儀婷", "張秉華", "陳柏霖", "黃紀瑜", "黃昱維", "蔡逸群", "登琳", "世新魏鈞孝吧", "劉定南", "陳信如", "童信傑", "李岳倫", "鄒和恆", "簡毓玟", "劉子瑄", "蕭紹洋", "李亞宸la", "張以潔", "邱仕紳", "呂家瑩", "世新林鑫佑", "徐均得", "陳佳欣", "張恩瑋", "周詮", "王湘婷", "蕭宇成", "Max Cheung(BANG)", "馬嘉誠Σヽ(ﾟД ﾟ; )ﾉ魔貫光殺砲(ﾟДﾟ)σ━0000", "陳昱嘉", "康珈熏", "盧奕宏", "陳郁佳的大哥黃博涵", "遲正雯", "世新林星彤", "許晏誠ｘ勒是奇多＿８＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝Ｄ　", "許子安", "高子晴", "陳思婷", "矝鵘鮿", "余彥廷", "吳耀輝", "鄭丞智", "林冠廷", "世新何曜宇", "邵喬雨", "張豐愷", "林子晴", "邱雁回", "陳家欣是韓妞", "鄧雅馨", "謝汶珊", "李曼寧", "世新徐偉哲", "张钰慈", "鍾宜珊", "raer_tsai", "世新李姳諼", "鄭曼君", "陳柏霖", "世新許子安", "世新方若帆", "李曼寧", "世新遲正雯", "世新周詮" };
            string[] Genders = { "男", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "男", "女", "男", "男", "男", "女", "女", "男", "男", "女", "男", "女", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "女", "男", "男", "女", "女", "男", "男", "女", "女", "男", "男", "男", "男", "男", "男", "女", "男", "女", "女", "女", "女", "女", "女", "男", "女", "女", "女", "女", "女", "男", "男", "女", "女", "女", "男" };
            string[] Zodiacs = { "金牛", "", "巨蟹", "白羊", "雙魚", "雙子", "天蠍", "巨蟹", "獅子", "雙魚", "雙子", "雙子", "獅子", "雙魚", "天蠍", "天蠍", "處女", "處女", "金牛", "雙魚", "處女", "摩羯", "雙魚", "白羊", "天蠍", "處女", "雙子", "金牛", "雙子", "白羊", "白羊", "摩羯", "射手", "巨蟹", "雙魚", "獅子", "射手", "摩羯", "天蠍", "", "雙魚", "雙子", "", "雙魚", "處女", "金牛", "天秤", "水瓶", "巨蟹", "處女", "白羊", "摩羯", "水瓶", "天秤", "金牛", "天蠍", "天蠍", "處女", "", "", "摩羯", "天蠍", "雙子", "", "獅子", "天蠍", "射手", "金牛" };
            int[] Height = { 173, 0, 179, 155, 183, 170, 163, 174, 165, 189, 177, 180, 154, 167, 170, 173, 165, 158, 180, 165, 153, 175, 162, 165, 0, 160, 165, 173, 164, 177, 177, 180, 170, 151, 176, 180, 168, 152, 666, 2147483647, 165, 155, 777, 173, 169, 170, 169, 171, 0, 170, 150, 160, 155, 164, 163, 165, 184, 165, 155, 0, 168, 160, 169, 0, 150, 163, 168, 173 };

            int Boy = 0;
            int Girl = 0;
            int TypeA = 0;
            int TypeB = 0;
            int TypeO = 0;
            int TypeAB = 0;
            int TypeElse = 0;
            // 設女生身高總和
            int HeightGirl = 0;

            // 設男生身高總和
            int HeightBoy = 0;

            // 設全班最矮身高
            int Min = 0;

            // 設全班最高身高
            int Max = 0;

            for (int l = 0; l < Genders.Length; l++)
            {
                if (Genders[l] == "男")
                {
                    Boy++;
                }
            }
            for (int l = 0; l < Genders.Length; l++)
            {
                if (Genders[l] == "女")
                {
                    Girl++;
                }
            }

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

            for (int k = 0; k < Names.Length; k++)
            {

                // 計算最高身高
                if (Height[k] > Max)
                {
                    Max = Height[k];
                }

                // 計算最矮身高
                if (Height[k] < Min)
                {
                    Min = Height[k];
                }

                // 計算女生有幾人，把女生身高都加總
                if (Genders[k] == "女")
                {
                    Girl++;
                    HeightGirl += Height[k];
                }

                // 計算男生有幾人，把男生身高都加總
                if (Genders[k] == "男")
                {
                    Boy++;
                    HeightBoy += Height[k];
                }


                double NBoy = (double)Boy / (double)Genders.Length * 100;
                double NGirl = (double)Girl / (double)Genders.Length * 100;

                double typeOp = (double)TypeO / (double)68 * 100;
                double typeAp = (double)TypeA / (double)68 * 100;
                double typeBp = (double)TypeB / (double)68 * 100;
                double typeABp = (double)TypeAB / (double)68 * 100;
                double typeEp = (double)TypeElse / (double)68 * 100;

                // 計算女生身高平均
                double HightGirlAverage = (double)HeightGirl / (double)Girl;
                double HightBoyAverage = (double)HeightBoy / (double)Boy;

                Console.WriteLine("男生人數:" + Boy + "，占全班：" + NBoy + "%");
                Console.WriteLine("");
                Console.WriteLine("女生人數:" + Girl + "，占全班：" + NGirl + "%");
                Console.WriteLine("");
                Console.WriteLine("A型人數:" + TypeA.ToString() + "占全班比例:" + typeAp + "%");
                Console.WriteLine("");
                Console.WriteLine("B型人數:" + TypeB.ToString() + "，占全班比例:" + typeBp + "%");
                Console.WriteLine("");
                Console.WriteLine("AB型人數:" + TypeAB.ToString() + "，占全班比例:" + typeABp + "%");
                Console.WriteLine("");
                Console.WriteLine("O型人數:" + TypeO.ToString() + "，占全班比例:" + typeOp + "%");
                Console.WriteLine("");
                Console.WriteLine("其他人數血型:" + TypeElse.ToString() + "，占全班比例:" + typeEp + "%");
                Console.WriteLine("");
                Console.WriteLine("男生身高平均:" + HightBoyAverage + "cm");
                Console.WriteLine("");
                Console.WriteLine("女生身高平均:" + HightGirlAverage + "cm");
                Console.WriteLine("");
                Console.WriteLine("全班平均身高:");
                Console.WriteLine("");
                Console.WriteLine("天蠍座O型:");
                Console.WriteLine("");

                Console.Read();
            }
        }
    }
}
