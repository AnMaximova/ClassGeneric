using System;

namespace ClassGeneric
{
    public class ProcessingDouble : Access<double>
    {
        private double n;
        public ProcessingDouble()
        {
            n = default(double);
        }
        public override double Input_Value()
        {
            n = double.Parse(Console.ReadLine());
            return n;
        }

        public override double Random_Value()
        {
            Random rnd = new Random();
            n = rnd.NextDouble()*rnd.Next(-100,101);
            return n;
        }
        public override string ValueToString(double val)
        {
            return string.Format("{0:f2}", val);
        }
    }
}
