using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Song[] TopFiveUSCharts = new Song[5];
            Song Num1 = new Song("RAPSTAR", "Polo G", "RAPSTAR");
            Song Num2 = new Song("MONTERO (Call Me By Your Name)", "Lil Nas X", "MONTERO (Call Me By Your Name)");
            Song Num3 = new Song("Peaches", "Justin Bieber, Daniel Caesar & Giveon", "Justice");
            Song Num4 = new Song("Kiss Me More", "Doja Cat & SZA", "Kiss Me More");
            Song Num5 = new Song("deja vu", "Olivia Rodrigo", "deja vu");
            TopFiveUSCharts[0] = Num1;
            TopFiveUSCharts[1] = Num2;
            TopFiveUSCharts[2] = Num3;
            TopFiveUSCharts[3] = Num4;
            TopFiveUSCharts[4] = Num5;
            Console.WriteLine("The Top 5 Songs on the U.S. Chart");
            for(int i = 0; i <= 4; i++)
            {
                Console.WriteLine(TopFiveUSCharts[i].Title + " by " + TopFiveUSCharts[i].Artist);
            }
        }
    }
}
