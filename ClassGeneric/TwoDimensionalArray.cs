using System;
using System.Xml.Linq;

namespace ClassGeneric
{
    public sealed class TwoDimensionalArray<T> : HeirArray<T>, IPrinter
     {
        private T[,] arr; //массив
        Access<T> access;

         public TwoDimensionalArray(Access<T> item, bool input_mode = false) : base(item, input_mode)
         {
         }
         private int VerifiedInput(out int n) //ввод количества строк и столбцов в двумерном массиве
         {
             int m;
             bool success;
             do
             {
                 Console.Write("Введите количество строк в матрице: ");
                 success = int.TryParse(Console.ReadLine(), out m);
             }
             while (!success || m <= 0);
             do
             {
                 Console.Write("Введите количество столбцов в матрице: ");
                 success = int.TryParse(Console.ReadLine(), out n);
             }
             while (!success || n <= 0);
             return m;
         }
        protected override void InputUser(Access<T> item)
         {
             int row;
             int column;
             access = item;
             row = VerifiedInput(out column);
             arr = new T[row, column];
             Type type_arr = typeof(T);
             Console.WriteLine($"Создаем двумерный массив типа {type_arr}");
            for (int i = 0; i < arr.GetLength(0); i++)
             {
                 for (int j = 0; j < arr.GetLength(1); j++)
                 {
                     Console.Write($"Элемент [{i},{j}]: ");
                     arr[i,j] = access.Input_Value();
                }
             }
         }
         protected override void InputRandom(Access<T> item)
         {
             Random rnd = new Random();
             access = item;
             arr = new T[rnd.Next(2, 11), rnd.Next(2, 11)];
             for (int i = 0; i < arr.GetLength(0); i++)
             {
                 for (int j = 0; j < arr.GetLength(1); j++)
                 {
                    arr[i,j] = access.Random_Value();
                }
             }
         }


         public override void Print() // вывод двумерного массива
         {
            Type type_arr = typeof(T);
            Console.WriteLine($"Выводим двумерный массив типа {type_arr}");
             for (int i = 0; i < arr.GetLength(0); i++)
             {
                 for (int j = 0; j < arr.GetLength(1); j++)
                 {
                    string str = access.ValueToString(arr[i,j]);
                    Console.Write(str + "\t");
                 }
                 Console.Write("\n");
             }
         }
    }  
}