using System;
using System.Runtime.InteropServices;

namespace ClassGeneric
{
    public class ProcessingString : IAccess<string>
    {
        private string n;
        public ProcessingString()
        {
            n = "";
        }
        public string Input_Value()
        {
            n = Console.ReadLine();
            return n;
        }

        public string Random_Value()
        {
            Random rnd = new Random();
            int len = rnd.Next(3,8);
            char[] chars = new char[len];
            for (int i = 0; i < len; i++)
            {
                int num = rnd.Next(33, 256);
                chars[i] = (char)num; 
            }
            string str = new string(chars);
            return str;
        }
        public string ValueToString(string val)
        {
            return val;
        }
    }
}
