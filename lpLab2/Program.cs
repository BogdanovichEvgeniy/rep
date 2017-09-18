using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lpLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1)
            //a) определение переменных
            System.SByte number1 = 1;
            System.Int16 number2 = -2;
            System.Int32 number3 = -3;
            System.Int64 number4 = -4;
            System.Byte number5 = 5;
            System.UInt16 number6 = 6;
            System.UInt32 number7 = 7;
            System.UInt64 number8 = 8;
            System.Char number9 = 'a';
            System.Boolean number10 = false;
            System.Single number11 = 9.5F;
            System.Double number12 = 5.55555;
            System.Decimal number13 = 51.5m;
            System.String nubmer14 = "People";
            System.Object number15 = 56;
            //b) неявные и явные преобразования преобразования
            System.Int16 i16 = number1;
            System.Int32 i32 = number2;
            System.Int64 i64 = i32;
            System.Single flot = i64;
            System.Single doub = flot;
            //----------------------------------------------
            System.Byte b = (Byte)number2;
            System.Byte b1 = (Byte)number4;
            System.Int16 ii16 = (Int16)number8;
            System.Int32 ii32 = (Int32)number11;
            System.Single ss = (Single)number12;
            //c) упаковка и распоковка значимых типов 
            System.Int32 x = 100;
            System.Object Ob = x;

            System.Double dd = (Double)(Int32)Ob;
            //d) неявно типизированная переменная
            var i_nt = 3;
            Console.WriteLine(i_nt.GetType());
            var str = "hello";
            Console.WriteLine(str.GetType());
            //e)Nullable переменная 
            System.Nullable<Int32> a = null;
            Int32? nn = null;
            if (a == null)
            {
                Console.WriteLine("a=null");
            }
            else
            {
                Console.WriteLine("a не равно null");
            }
            //2) Строки
            //a) Объявите строковые литералы. Сравните их.
            System.String str1 = "Aord";
            System.String str2 = "Vord";
            Console.WriteLine(String.Compare(str2, str1));
            Console.WriteLine(String.CompareOrdinal(str2, str1));
            int dif = str2.CompareTo(str1);
            Console.WriteLine(dif);
            /*b. Создайте три строки на основе String. Выполните: сцепление, копирование,
            выделение подстроки, разделение строки на слова, вставки подстроки в заданную позицию,
            удаление заданной подстроки.*/
            System.String sstr1 = "Aorod";
            System.String sstr2 = "Bord";
            System.String sstr3 = "Cord$hello$world";

            Console.WriteLine(String.Concat(sstr1, sstr2));
            System.String cop = String.Copy(sstr3);
            Console.WriteLine(cop);
            Console.WriteLine(sstr1.Substring(2, 3));
            String[] words = sstr3.Split('$');
            Console.WriteLine(words[0]);
            Console.WriteLine(words[1]);
            Console.WriteLine(words[2]);
            Console.WriteLine(sstr2.Insert(2, "____"));
            Console.WriteLine(sstr2);
            System.Int32 size = sstr2.Length;
            sstr2 = sstr2.Remove(0, size);
            Console.WriteLine(sstr2);
            //c. Создайте пустую и null строку. Продемонстрируйте что можно выполнить с такими строками 
            System.String str0 = "";
            str0 = String.Concat(str0, sstr1);
            Console.WriteLine(str0);
            System.String nstring = null;
            nstring = String.Concat(nstring, sstr3);
            Console.WriteLine(nstring);
            //d. Создайте строку на основе StringBuilder. Удалите определенные позиции и добавьте новые
            //символы в начало и конец строки
            StringBuilder strok = new StringBuilder("hello", 20);
            strok.Remove(0, 1);
            strok.Remove(3, 1);
            Console.WriteLine(strok);
            strok.Insert(0, 'h');
            strok.Insert(4, 'o');
            strok.Append("!!!");
            Console.WriteLine(strok);
            //3) Массивы
            //a. Создайте целый двумерный массив и выведите его на консоль в отформатированном виде (матрица). 
            int[,] array = { 
                             {1,3,5},
                             {8,6,1}
                           };
            Console.WriteLine("Матрица :");
            for (int i=0; i<2; i++)
            {
                for(int j=0;j<3; j++)
                {
                    Console.Write(array[i,j]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
            //b. Создайте одномерный массив строк. Выведите на консоль его содержимое, длину массива.
            //Поменяйте произвольный элемент (пользователь определяет позицию и значение). 
            String[] sttr = { "Wo","_","r","l","d"};
            foreach(String i in sttr)
            {
                Console.Write(i);
            }
            Console.WriteLine();
            Console.WriteLine(sttr.Length);
            Console.Write($"Введите позицию, до {sttr.Length}: ");
            System.Int32 position;
            position = Int32.Parse(Console.ReadLine());
            Console.WriteLine(position);
            System.String inf;
            Console.Write("Введите элемент:");
            inf = (Console.ReadLine());
            sttr[position] = inf;
            foreach (String i in sttr)
            {
                Console.Write(i);
            }
            Console.WriteLine();
            //c. Создайте ступечатый (не выровненный) массив вещественных чисел с 3-мя строками, в 
            //каждой из которых 2, 3 и 4 столбцов соответственно. Значения массива введите с консоли.
            double[][] Darray=new double[3][];
            Darray[0] = new double[2];
            Darray[1] = new double[3];
            Darray[2] = new double[4];
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < 2; i++)
            { Darray[0][i] = Double.Parse(Console.ReadLine()); }
            for (int i = 0; i < 3; i++)
            { Darray[1][i] = Double.Parse(Console.ReadLine()); }
            for (int i = 0; i < 4; i++)
            { Darray[2][i] = Double.Parse(Console.ReadLine()); }
            Console.WriteLine("Ступенчатый массив:");
            foreach (double[] i in Darray)
            {
                foreach (double j in i)
                {
                    Console.Write("\t" + j);
                }
                Console.WriteLine();
            }
            //d.Создайте неявно типизированные переменные для хранения массива и строки.
            Console.WriteLine();
            var stroc = "house№1";
            Console.WriteLine();
            var array1 = new[] {1,2,3,4};
            Console.WriteLine(stroc);
            foreach (var i in array1)
            {
                Console.Write("\t"+i);
            }
            Console.WriteLine();
            Console.WriteLine("__________________________________________________");
            Console.WriteLine();
            //4) Кортежи 
            //a) Задайте кортеж из 5 элементов с типами int, string, char, string, ulong. 
            (Int32 num0, String num1, Char num2, String num3, UInt64 num4) tuple = (32, "world", 'A', "hello",44);
            Console.WriteLine($"Kортеж {tuple}");
            Console.WriteLine(tuple.num0+" "+tuple.num2+" "+tuple.num3);
            Console.WriteLine("-");
            var (o, t, th,f,fi) = (tuple);
            Console.WriteLine(o + " " + t + " " + th + " " + f + " " + fi);
            Console.WriteLine("-");
            Int32[] ar = { 2, 3, 8, 6, -1, 0, 6 };
            System.String s = "green";
            Console.WriteLine(fun(ar,s));
                (Int32, Int32, Int32, String) fun(Int32[] number, String name)
                {
                    Int32 max = 0, min = 0, sum = 0;
                    for (Int32 i = 0; i < 7; i++)
                    {
                        if (max < number[i])
                        {
                            max = number[i];
                        }
                    }
                    for (Int32 i = 0; i < 7; i++)
                    {
                        if (min > ar[i])
                        {
                            min = ar[i];
                        }
                    }
                    for (Int32 i = 0; i < 7; i++)
                    {
                        sum += ar[i];
                    }
                    System.String b_1 = name.Substring(0, 1);
                    return (max, min, sum, b_1);
                }

        }
    }
}
