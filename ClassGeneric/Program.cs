using System;
using ClassGeneric;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ввод одномерного массива строк");
        OneDimensionalArray<string> test1 = new OneDimensionalArray<string>(true);
        test1.Print();
        Console.WriteLine("Ввод двумерного массива целых чисел");
        TwoDimensionalArray<int> test2 = new TwoDimensionalArray<int>(true);
        test2.Print();
        Console.WriteLine("Нажмите любую клавишу для продолжения...");
        Console.ReadKey();

        OneDimensionalArray<int> one = new OneDimensionalArray<int>();
        OneDimensionalArray<double> two = new OneDimensionalArray<double>();
        OneDimensionalArray<bool> three = new OneDimensionalArray<bool>();
        OneDimensionalArray<string> four = new OneDimensionalArray<string>();
        TwoDimensionalArray<int> five = new TwoDimensionalArray<int>();
        TwoDimensionalArray<double> six = new TwoDimensionalArray<double>();
        TwoDimensionalArray<bool> seven = new TwoDimensionalArray<bool>();
        TwoDimensionalArray<string> eight = new TwoDimensionalArray<string>();
        // собираем все вместе и печатаем
        IPrinter[] printers = new IPrinter[8];
        printers[0] = one;
        printers[1] = two;
        printers[2] = three;
        printers[3] = four;
        printers[4] = five;
        printers[5] = six;
        printers[6] = seven;
        printers[7] = eight;
        for (int i = 0; i < printers.Length; i++)
        {
            printers[i].Print();
        }
    }
}

