using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            int word = 0;
            FileStream f1 = new FileStream("C:\\Users/Hydra/Desktop/1 задание/1 задание/bin/Debug/student123.txt", FileMode.Open);
            StreamReader rd = new StreamReader(f1);
            string f = rd.ReadToEnd();
            for (int i = 0; i < f.Length; i++)
                if (f[i] == 'S' && f[i + 1] == 'T' && f[i + 2] == 'U' && f[i + 3] == 'D' && f[i + 4] == 'E' && f[i + 5] == 'N' && f[i + 6] == 'T') word++;
            Console.WriteLine("Слово \"STUDENT\" встречалось в файле " + word + " раз(а)");
            Console.ReadKey(true);
            rd.Close();
            f1.Close();
        }
    }
}
