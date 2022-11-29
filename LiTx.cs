using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMachine
{
    public class LiTx
    {
        public static string? input(string msg)
        {
            Console.Write($"\n{msg}");
            string? info = Console.ReadLine();

            if (info == null)
            {
                info = "";
            }
            if (info.Length < 1)
            {
                input(msg);
            }
            return info;
        }
    }
}
