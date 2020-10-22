using System;
using System.Diagnostics;
using System.IO;
using System.Linq;


namespace O.R.K.A._Project_ver._2._0
{
    public class Methods
    {
        public void Sleep(int time)
        {
            System.Threading.Thread.Sleep(time);
        }

        public void Clear()
        {
            Console.Clear();
        }

        public void Ent()
        {
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }

        public void Els()
        {
            Console.WriteLine("Dev Log: Jesteś debilem");
            Sleep(1000);
            Ent();
        }
    }
}