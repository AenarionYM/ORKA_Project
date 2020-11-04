using System;


namespace O.R.K.A._Project_ver._2._0
{
    public class Methods
    {
        public static void Sleep(int time)
        {
            System.Threading.Thread.Sleep(time);
        }
        
        public static void SleepEq()
        {
            System.Threading.Thread.Sleep(100);
        }

        public static void Clear()
        {
            Console.Clear();
        }

        public static void Ent()
        {
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }

        public static void Els()
        {
            Console.WriteLine("Dev Log: Jesteś debilem");
            Sleep(500);
            Ent();
        }

        public static void Rep()
        {
            Console.WriteLine("\n*Dostałeś naganę*");
            Eq.reprimands++;
            Sleep(500);
            Console.WriteLine($"{Eq.reprimands} / 3");
            Ent();
            Clear();
        }
    }
}