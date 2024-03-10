using System;


namespace ClassGeneric
{
    public class ProcessingBool : Access<bool>
    {
        private bool n;
        public ProcessingBool()
        {
            n = default(bool);
        }
        public override bool Input_Value()
        {
            n = bool.Parse(Console.ReadLine());
            return n;
        }

        public override bool Random_Value()
        {
            Random rnd = new Random();
            int num = rnd.Next(-10,10);
            if (num >= 0) 
            {
                n = true;
            }
            else 
            {
                n = false;
            }
            return n;
        }
        public override string ValueToString(bool val)
        {
            return val.ToString();
        }
    }
}
