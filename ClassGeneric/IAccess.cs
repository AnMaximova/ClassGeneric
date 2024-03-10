﻿using System;

namespace ClassGeneric
{
    public abstract class IAccess<T>
    {
        public abstract T Input_Value();
        public abstract T Random_Value();
        public abstract string ValueToString(T val);
    }
}
