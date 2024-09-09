using System;

namespace ConsoleApp1
{
    internal class Program
    {
        #region 1)
        static void Main(string[] args)
        {
            if (args.Length < 3 && args.Length % 2 == 0)
            {
                Console.WriteLine("Nem megfelelő argumentum szám!");
                return;
            }

            int[] szamok = [
                    Convert.ToInt32(args[args.Length/2 - 1]),
                    Convert.ToInt32(args[args.Length/2 + 1]),
                    Convert.ToInt32(args[args.Length/2])
                ];
            int hatvany = Math.Max(szamok[0] / szamok[1], szamok[1] / szamok[0]);

            Console.WriteLine($"Eredmény: {Math.Pow(szamok[2], hatvany)}");
        }
        #endregion

        #region 2)
        //static void Main(string[] args)
        //{
        //    string[] szavak = File.ReadAllLines("M:\\feladatok_IKT\\szavak.txt")
        //        .Where(G => G.Count(G => "AÁEÉIÍOÓÖŐUÚÜŰ".Contains(G)) >= 4)
        //        .ToArray();
        //    int legnagyobb = szavak.Max(G => G.Count(G => "AÁEÉIÍOÓÖŐUÚÜŰ".Contains(G)));

        //    Console.WriteLine($"A több, mint 4 szótagból álló szavak száma: {szavak.Length}");
        //    Console.WriteLine($"A legnagyobb szótagszám: {legnagyobb}");
        //}
        #endregion

        #region 3)
        //static void Main(string[] args)
        //{
        //    int[,] nums = new int[6, 6];
        //    int sum = 0;
        //    Random rand = new(33);

        //    for (int i = 0; i < 6; i++)
        //    {
        //        for (int j = 0; j < 6; j++)
        //        {
        //            nums[i, j] = rand.Next(55, 156);
        //            sum += nums[i, j];
        //            Console.Write($"{nums[i, j],3} ");
        //        }
        //        Console.WriteLine();
        //    }

        //    Console.WriteLine($"Szélső elemek átlaga: {sum / 36.0:f2}");
        //}
        #endregion

        //record RGB(byte r, byte g, byte b);
        //static void Main(string[] args)
        //{
        //    RGB[] szinek = File.ReadAllLines("M:\\feladatok_IKT\\kep.txt")
        //                       .Select(G => Array.ConvertAll(G.Split(';'), Convert.ToByte))
        //                       .Select(G => new RGB(G[0], G[1], G[2]))
        //                       .ToArray();

        //    RGB[] ujSzinek = szinek.Select(G => G.b < 100 ? new RGB(G.r, G.g, (byte)(G.b+20)) : G).ToArray();
        //    File.WriteAllLines("kekitett.txt", ujSzinek.Select(G => $"{G.r};{G.g};{G.b}"));
        //    Console.WriteLine("#Kész!");
        //}
    }
}