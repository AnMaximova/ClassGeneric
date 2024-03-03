using System;

namespace ClassGeneric
{
    public sealed class OneDimensionalArray<T> : HeirArray, IPrinter
    {
        private T[] arr; //массив

        public OneDimensionalArray(bool input_mode = false) : base(input_mode)
        {
        }

        private int VerifiedInput() //ввод размера массива
        {
            int n;
            bool success;
            do
            {
                Console.Write("Введите размер массива: ");
                success = int.TryParse(Console.ReadLine(), out n);
            }
            while (!success || n <= 0);
            return n;
        }
        protected override void InputUser()
        {
            arr = new T[VerifiedInput()];
            Type type_arr = typeof(T);
            Console.WriteLine($"Создаем массив типа {type_arr}");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Введите {i} элемент массива: ");
                IAccess<T>[] g = new IAccess<T>[1];
                DetermineType(ref g);
                arr[i] = g[0].Input_Value();
            }
        }
        protected override void InputRandom()
        {
            Random rnd = new Random();
            arr = new T[rnd.Next(3, 11)];
            for (int i = 0; i < arr.Length; i++)
            {
                IAccess<T>[] g = new IAccess<T>[1];
                DetermineType(ref g);
                arr[i] = g[0].Random_Value();
            }
        }

        public override void Print() // вывод массива в строку
        {
            Type type_arr = typeof(T);
            Console.WriteLine($"Выводим массив типа {type_arr}");
            foreach (T element in arr)
            {
                IAccess<T>[] g = new IAccess<T>[1];
                DetermineType(ref g);
                string str = g[0].ValueToString(element);
                Console.Write(str + "\t");
            }       
            Console.WriteLine();
        }

        private void DetermineType(ref IAccess<T>[] g)
        {
            Type type_arr = typeof(T);
            switch (type_arr.ToString())
            {
                case "System.Int32":
                    ProcessingInt gen1 = new ProcessingInt();
                    g[0] = (IAccess<T>)gen1;
                    break;
                case "System.Double":
                    ProcessingDouble gen2 = new ProcessingDouble();
                    g[0] = (IAccess<T>)gen2;
                    break;
                case "System.Boolean":
                    ProcessingBool gen3 = new ProcessingBool();
                    g[0] = (IAccess<T>)gen3;
                    break;
                case "System.String":
                    ProcessingString gen4 = new ProcessingString();
                    g[0] = (IAccess<T>)gen4;
                    break;
            }
        }
    }
}
