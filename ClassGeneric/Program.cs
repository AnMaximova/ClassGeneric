using System;
using ClassGeneric;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ввод одномерного массива строк");
        Access<string> item1 = new ProcessingString();
        OneDimensionalArray<string> test1 = new OneDimensionalArray<string>(item1,true);
        test1.Print();
        Console.WriteLine("Ввод двумерного массива целых чисел");
        Access<int> item2 = new ProcessingInt();
        TwoDimensionalArray<int> test2 = new TwoDimensionalArray<int>(item2, true);
        test2.Print();
        Console.WriteLine("Нажмите любую клавишу для продолжения...");
        Console.ReadKey();

        Access<int> t1 = new ProcessingInt();
        OneDimensionalArray<int> one = new OneDimensionalArray<int>(t1);
        Access<double> t2 = new ProcessingDouble();
        OneDimensionalArray<double> two = new OneDimensionalArray<double>(t2);
        Access<bool> t3 = new ProcessingBool();
        OneDimensionalArray<bool> three = new OneDimensionalArray<bool>(t3);
        Access<string> t4 = new ProcessingString();
        OneDimensionalArray<string> four = new OneDimensionalArray<string>(t4);
        Access<int> t5 = new ProcessingInt();
        TwoDimensionalArray<int> five = new TwoDimensionalArray<int>(t5);
        Access<double> t6 = new ProcessingDouble();
        TwoDimensionalArray<double> six = new TwoDimensionalArray<double>(t6);
        Access<bool> t7 = new ProcessingBool();
        TwoDimensionalArray<bool> seven = new TwoDimensionalArray<bool>(t7);
        Access<string> t8 = new ProcessingString();
        TwoDimensionalArray<string> eight = new TwoDimensionalArray<string>(t8);
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

