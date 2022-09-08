using System;
using System.Text;

namespace Laba1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Задание 1a
            //Логический тип bool 
            Console.WriteLine("-------------------Логические типы-------------------");
            bool log = true; //true или false 
            Console.WriteLine("bool --> " + log);
            Console.Write("Введите значение boolean:");
            log = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Новое значение boolean --> " + log);

            //Целочисленные типы:
            Console.WriteLine("-------------------Целочисленные типы----------------");
            int a = 2; //от -2147483648 до 2147483647 и занимает 4 байта
            Console.WriteLine("Int --> " + a);
            Console.Write("Введите значение Int: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Новое значение Int --> " + a);

            uint b = 4; //0 до 4294967295 и занимает 4 байта 
            Console.WriteLine("Uint --> " + b);
            Console.Write("Введите значение Uint: ");
            b = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Новое значение Uint --> " + b);

            short sh = -1102; //от -32768 до 32767 и занимает 2 байта
            Console.WriteLine("Short --> " + sh);
            Console.Write("Введите значение Short:");
            sh = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Новое значение Short --> " + sh);

            ushort ush = 13525; //от 0 до 65535 и занимает 2 байта
            Console.WriteLine("Ushort --> " + ush);
            Console.Write("Введите значение Ushort: ");
            ush = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Новое значение Ushort --> " + ush);

            byte bt = 255; //от 0 до 255 занимает 1 байт
            Console.WriteLine("Byte --> " + bt);
            Console.Write("Введите значение Byte: ");
            bt = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Новое значение Byte --> " + bt);

            sbyte sbt = 100; //от -128 до 127 и занимает 1 байт
            Console.WriteLine("Sbyte --> " + sbt);
            Console.Write("Введите значение Sbyte: ");
            sbt = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("Новое значение Sbyte --> " + sbt);

            long lg = 124135522342352; // –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт
            Console.WriteLine("Long --> " + lg);
            Console.Write("Введите значение Long ");
            lg = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Новое значение long --> " + lg);

            ulong ulg = 6342142645234; //0 до 18 446 744 073 709 551 615 и занимает 8 байт
            Console.WriteLine("Ulong --> " + ulg);
            Console.Write("Введите значение Ulong: ");
            ulg = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("Новое значение Ulong --> " + ulg);

            //Числа с плавающей точкой
            Console.WriteLine("-------------------Числа с плавающей точкой----------------");
            float fl = 14; //-3.4*10(38) до 3.4*10(38) и занимает 4 байта
            Console.WriteLine("Float --> " + fl);
            Console.Write("Введите значение Float: ");
            fl = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Новое значение Float --> " + fl);

            double db = 0.655467; //±5.0*10-324 до ±1.7*10(308) и занимает 8 байт
            Console.WriteLine("Double --> " + db);
            Console.Write("Введите значение Double: ");
            db = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Новое значение Double --> " + db);

            //Строка
            Console.WriteLine("-------------------Строки----------------");
            string str = "Привет мир!";
            Console.WriteLine("String --> " + str);
            Console.Write("Введите значение String: ");
            str = Console.ReadLine();
            Console.WriteLine("Новое значение String --> " + str);

            //Символ
            Console.WriteLine("-------------------Символ----------------");
            char ch = 'a'; // занимает 2 байта
            Console.WriteLine("Char --> " + ch);
            Console.Write("Введите значение Char: ");
            ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Новое значение Char --> " + ch);

            //Десятичный тип
            Console.WriteLine("-------------------Десятичный тип----------------");
            decimal dc = 7; //от ±1.0*10-28 до ±7.9228*1028, может хранить 28 знаков после запятой и занимает 16 байт
            Console.WriteLine("Demical --> " + dc);
            Console.Write("Введите значение Demical: ");
            dc = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Новое значение Demical --> " + dc);

            //Задание 1b
            //Явные преобразования
            long yp1 = (long)a; //потеря данных
            short yp2 = (short)bt;
            byte yp3 = (byte)ush;
            int yp4 = (int)b;
            ulong yp5 = (ulong)lg;

            //Неявное преобразование
            long np1 = a; //диапазон
            float np2 = lg;
            ulong np3 = b;
            double np4 = fl;
            int np5 = ush;

            //Задание 1c
            int box = 6;
            Console.WriteLine("box = " + box);
            object o = box; //Упаковка 
            int unbox = (int)o;//Распаковка
            Console.Write("Распаковка " + unbox);


            //Задание 1d //неявно типизированные переменные
            var str2 = "hello";
            var num = 13;
            var ch2 = 'r';

            //Задание 1e
            int? n1 = null;
            if (n1.HasValue)
            {
                Console.WriteLine(n1.Value);
            }
            else
            {
                Console.WriteLine("Нет значения");
            }

            //Задание 1f
            var err = 5;
            //err = 0.4; - ОШИБКА! Компилятор видит, что мы к var присвоили значение int и после переназначения в
            //число типа double компилятор выдаёт ошибку

            
        }
    }
}