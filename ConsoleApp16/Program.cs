using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static public void Encode(string ch)
        {
            int[] i = new int[100];
            int j = 0;
            ch = ch.ToUpper();
            string[] cod = { "4", "8", "(", "[)", "3", "|=", "9", "#", "1", "_|", "X", "1", "|v|", "^/", "0", "|*", "(_,)", "2", "5", "7", "(_)", "\\/", "\\/\\/", "><", "7", ">_" };
            for(int x = 0;x <= ch.Length - 1;x++)
            { 
                i[x] = Convert.ToInt32(ch[x]);
                j++;
            }
            for(int k = 0;k <= j;k++)
            {
                i[k] = i[k] - 65;
            }
            for(int k = 0;k < j;k++)
            {
                if (i[k] < 0 || i[k] > 25)
                {
                    i[k] = i[k] + 65;
                    System.Console.Write(Convert.ToChar(i[k]));
                }
                else
                    System.Console.Write(cod[i[k]]);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Use 'ctrl^c' to exit");
            while(true)
                Encode(Console.ReadLine().ToString());
        }
    }
}
