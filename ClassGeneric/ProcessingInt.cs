using System;

namespace ClassGeneric
{
    public class ProcessingInt : IAccess<int>
    {
        private int n;
        public ProcessingInt()
        {
            n = default(int);
        }
        public int Input_Value()
        {
            n = int.Parse(Console.ReadLine());
            return n;
        }
        public int Random_Value()
        {
            Random rnd = new Random();
            n = rnd.Next(-200, 201);
            return n;
        }
        public string ValueToString(int val)
        { 
            return val.ToString();
        }
    }
}
