using System;
using System.Data;

namespace SectionLogic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Grade();
            //star();
            piramidaTerbalik();
        }

        static void Grade()
        {
            string[] Siswa = { "Siswa A", "Siswa B", "Siswa C" };
            double[] Kehadiran = { 10 ,6 ,8};
            double[] UTS = {7 ,9 ,8.5 };
            double[] UAS = { 8.5 ,7.5 ,6 };
            //Console.Write("Nilai Kehadiran : ");
            //int Kehadiran = int.Parse(Console.ReadLine());
            //Console.Write("Nilai UTS : ");
            //int UTS = int.Parse(Console.ReadLine());
            //Console.Write("Nilai UAS : ");
            //int UAS = int.Parse(Console.ReadLine());
            string result = "";
            for (int i = 0; i < Kehadiran.Length; i++)
            {
                double Grade = (Kehadiran[i] * (0.05)) + (UTS[i] * (0.4)) + (UAS[i] * (0.55));

                if (Grade >= 9.7)
                {
                    result = "A+";
                }
                else if (Grade >= 9.3)
                {
                    result = "A";
                }
                else if (Grade >= 8.5)
                {
                    result = "A-";
                }
                else if (Grade >= 7.7)
                {
                    result = "B+";
                }
                else if (Grade >= 7.0)
                {
                    result = "B-";
                }
                else if (Grade >= 4.5)
                {
                    result = "C";
                }
                else
                {
                    result = "C-";
                }
                Console.WriteLine($"Nilai {Siswa[i]} : " + Grade);
                Console.WriteLine(Siswa[i]+ " = " +result);
            }
        }

        static void star()
        {
            Console.Write("Banyak star : ");
            int star = int.Parse(Console.ReadLine());

            for (int i =1; i <= star; i++)
            {
                for (int j = 0; j < star; j++)
                {
                    if (j >= i)
                    {
                        Console.Write("*");
                    }
                    else 
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
        }

        static void piramidaTerbalik()
        {
            Console.Write("Input tinggi piramida terbalik= ");
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int spasi = 0;
            int bintang = ((n - 1) * 2) + 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < spasi; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < bintang; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                spasi += 2;
                bintang -= 2;
            }

        }
    }
}
