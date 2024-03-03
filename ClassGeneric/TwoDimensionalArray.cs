using System;
using System.Xml.Linq;

namespace ClassGeneric
{
    public sealed class TwoDimensionalArray<T> : HeirArray, IPrinter
     {
         private T[,] arr; //массив

         public TwoDimensionalArray(bool input_mode = false) : base(input_mode)
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
         protected override void InputUser()
         {
             int row;
             int column;
             row = VerifiedInput(out column);
             arr = new T[row, column];
             Type type_arr = typeof(T);
             Console.WriteLine($"Создаем двумерный массив типа {type_arr}");
            for (int i = 0; i < arr.GetLength(0); i++)
             {
                 for (int j = 0; j < arr.GetLength(1); j++)
                 {
                     Console.Write($"Элемент [{i},{j}]: ");
                     IAccess<T>[] g = new IAccess<T>[1];
                     DetermineType(ref g);
                     arr[i,j] = g[0].Input_Value();
                }
             }
         }
         protected override void InputRandom()
         {
             Random rnd = new Random();
             arr = new T[rnd.Next(2, 11), rnd.Next(2, 11)];
             for (int i = 0; i < arr.GetLength(0); i++)
             {
                 for (int j = 0; j < arr.GetLength(1); j++)
                 {
                    IAccess<T>[] g = new IAccess<T>[1];
                    DetermineType(ref g);
                    arr[i,j] = g[0].Random_Value();
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
                    IAccess<T>[] g = new IAccess<T>[1];
                    DetermineType(ref g);
                    string str = g[0].ValueToString(arr[i,j]);
                    Console.Write(str + "\t");
                 }
                 Console.Write("\n");
             }
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
