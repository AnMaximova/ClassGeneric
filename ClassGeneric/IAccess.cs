using System;

namespace ClassGeneric
{
    public interface IAccess<T>
    {
        public T Input_Value();
        public T Random_Value();
        public string ValueToString(T val);
    }
}
