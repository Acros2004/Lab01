using System;
using System.Text;

namespace Laba1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Задание 1 A

            //Логический тип bool
            //true или false 
            Console.WriteLine("Логические типы");
            bool l = true;
            Console.WriteLine("bool= " + l);
            Console.Write("Введите значение bool:");
            l = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("bool= " + l);

            //Целочисленные типы:
            //от -2147483648 до 2147483647 и занимает 4 байта
            Console.WriteLine("Целочисленные типы");
            int a = -6;
            Console.WriteLine("Int= " + a);
            Console.Write("Введите значение Int: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Int= " + a);
            //0 до 4294967295 и занимает 4 байта 
            uint b = 4; 
            Console.WriteLine("Uint= " + b);
            Console.Write("Введите значение Uint: ");
            b = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Uint= " + b);

            //от -32768 до 32767 и занимает 2 байта
            short s = -32766; 
            Console.WriteLine("Short= " + s);
            Console.Write("Введите значение Short:");
            s = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Short= " + s);

            //от 0 до 65535 и занимает 2 байта
            ushort us = 65534; 
            Console.WriteLine("Ushort= " + us);
            Console.Write("Введите значение Ushort: ");
            us = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Ushort= " + us);

            //от 0 до 255 занимает 1 байт
            byte b1 = 255; 
            Console.WriteLine("Byte " + b1);
            Console.Write("Введите значение Byte: ");
            b1 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Byte= " + b1);

            //от -128 до 127 и занимает 1 байт
            sbyte sb1 = 126;
            Console.WriteLine("Sbyte= " + sb1);
            Console.Write("Введите значение Sbyte: ");
            sb1 = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("Sbyte= " + sb1);

            // –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт
            long lg = 124135522342352; 
            Console.WriteLine("Long= " + lg);
            Console.Write("Введите значение Long ");
            lg = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("long= " + lg);

            //0 до 18 446 744 073 709 551 615 и занимает 8 байт
            ulong ulg = 6342142645234; 
            Console.WriteLine("Ulong= " + ulg);
            Console.Write("Введите значение Ulong: ");
            ulg = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("Ulong= " + ulg);

            //Числа с плавающей точкой
            Console.WriteLine("Числа с плавающей точкой");
            //-3.4*10(38) до 3.4*10(38) и занимает 4 байта
            float fl = 14; 
            Console.WriteLine("Float= " + fl);
            Console.Write("Введите значение Float: ");
            fl = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Float= " + fl);

            //±5.0*10-324 до ±1.7*10(308) и занимает 8 байт
            double db = 0.655467; 
            Console.WriteLine("Double= " + db);
            Console.Write("Введите значение Double: ");
            db = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Double= " + db);

            //Строка
            Console.WriteLine("Строки");
            string str = "My name Nikita Karebo";
            Console.WriteLine("String " + str);
            Console.Write("Введите String: ");
            str = Console.ReadLine();
            Console.WriteLine("String " + str);

            //Символ
            Console.WriteLine("Char");
            char ch = 'a'; // занимает 2 байта
            Console.WriteLine("Char " + ch);
            Console.Write("Введите Char: ");
            ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Char= " + ch);

            //Десятичный тип
            Console.WriteLine("Десятичный тип");
            decimal dc = 7; //от ±1.0*10-28 до ±7.9228*1028, может хранить 28 знаков после запятой и занимает 16 байт
            Console.WriteLine("Demical= " + dc);
            Console.Write("Введите значение Demical: ");
            dc = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Demical= " + dc);

            //Задание 1b
            //Явные преобразования
            long yp1 = (long)a; //потеря данных
            short yp2 = (short)b1;
            byte yp3 = (byte)us;
            int yp4 = (int)b;
            ulong yp5 = (ulong)lg;

            //Неявное преобразование
            long np1 = a; //диапазон
            float np2 = lg;
            ulong np3 = b;
            double np4 = fl;
            int np5 = us;

            //Задание 1c
            int box = 6;
            Console.WriteLine("box = " + box);
            object o = box; //Упаковка 
            int unbox = (int)o;//Распаковка
            Console.Write("Распаковка " + unbox);


            //Задание 1d неявно типизированные переменные
            var str2 = "hello";
            var num = 13;
            var ch2 = 'r';

            //Задание 1e
            int? a1 = 1;
            int? b2 = null;
            Console.WriteLine(a1 ?? 3); // 1 (если а не тру или не существует, тогда 3)
            Console.WriteLine(b2 ?? 3); // 3

            //Задание 1f
            /*
            var quest_1f = "1F";
            quest_1f = 4;
            */
            /*
            Это не работает, потмоу что компилятор выводит нашей 
            переменной тип. Можно поменять значение переменной на тот
            же тип данных.
            */

            //Задание 2ab
            string stg1 = "Первая строка";
            string stg2 = "Вторая строка";
            string stg3 = "Третяя строка";

            // сравнение строк          
            Console.WriteLine("Сравнение(Compare) " + string.Compare(stg1, stg2));

            // слияние:
            Console.WriteLine("Слияние(Concat) " + string.Concat(stg1, stg2, stg3));

            // выделение подстроки:
            Console.WriteLine("Выделение(Substring) " + stg1.Substring(5));

            // копирование
            string cop = string.Copy(stg3);
            Console.WriteLine("Копирование " + cop);

            // разделение строки на слова
            string strfrsplt = "Этот текст был разделён на отдельные слова";
            string[] words = strfrsplt.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string strFE in words)
            {
                Console.WriteLine(strFE);
            }

            // вставка подстроки
            string strfrIns = "Раз два три ";
            string substr = "четыре";

            strfrIns = strfrIns.Insert(11, substr);
            Console.WriteLine(strfrIns);

            // удаление заданной подстроки
            Console.WriteLine("Удаление одного символа " + stg1.Remove(2, 1));

            //Задание 2c метод
            string nullstr = null;
            string emptystr = "";
            bool emptySTR1 = string.IsNullOrEmpty(nullstr);
            bool emptySTR2 = string.IsNullOrEmpty(emptystr);

            //Задание 2d
            StringBuilder strblr = new StringBuilder("StringBuilder");
            Console.WriteLine("Удаление 3 символов с начала --> " + strblr.Remove(0, 3));
            string sym = "Н";
            Console.WriteLine("символ Н в начало строки --> " + strblr.Insert(0, sym));
            Console.WriteLine("символ Н в конец строки --> " + strblr.Insert(strblr.Length, sym));
        }
    }
}