using System;

namespace ClassGeneric
{
    public sealed class OneDimensionalArray<T> : HeirArray<T>, IPrinter
    {
        private T[] arr; //массив
        Access<T> access;
                
        public OneDimensionalArray(Access<T> item, bool input_mode = false) : base(item, input_mode)
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
        protected override void InputUser(Access<T> item)
        {
            access = item;
            arr = new T[VerifiedInput()];
            Type type_arr = typeof(T);
            Console.WriteLine($"Создаем массив типа {type_arr}");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Введите {i} элемент массива: ");
                arr[i] = access.Input_Value();
            }
        }
        protected override void InputRandom(Access<T> item)
        {
            Random rnd = new Random();
            access = item;
            arr = new T[rnd.Next(3, 11)];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = access.Random_Value();
            }
        }

        public override void Print() // вывод массива в строку
        {
            Type type_arr = typeof(T);
            Console.WriteLine($"Выводим массив типа {type_arr}");
            foreach (T element in arr)
            {
                string str = access.ValueToString(element);
                Console.Write(str + "\t");
            }       
            Console.WriteLine();
        }
    }
}
