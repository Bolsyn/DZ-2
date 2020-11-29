using System;

namespace DZ_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.
            Random x = new Random();
            Console.Write(x.Next()%100);
            Console.Write("  ");
            Console.Write(x.Next()%500);
            Console.Write("  ");
            Console.WriteLine(x.Next()%1000);
            Console.WriteLine();

            // 2.Вывести на экран числа 5, 10 и 21 одно под другим.
            Console.WriteLine(5);
            Console.WriteLine(10);
            Console.WriteLine(21);
            Console.WriteLine();

            // 3.Дано расстояние в сантиметрах.Найти число полных метров в нем.
            int centimeter = x.Next()%1000;
            int meter = centimeter / 100;
            Console.WriteLine(meter);
            Console.WriteLine();

            // 4.С некоторого момента прошло 234 дня.Сколько полных недель прошло за этот период ?
            int days = 234;
            int weeks = days / 7;
            Console.WriteLine(weeks);
            Console.WriteLine();

            // 5.Дано двузначное число.Найти:
            int givenNumber = x.Next() % 100;
            Console.WriteLine(givenNumber);

            // a.число десятков в нем;
            int decades = givenNumber / 10;
            Console.WriteLine(decades);

            // b.число единиц в нем;
            int units = givenNumber % 10;
            Console.WriteLine(units);

            // c.сумму его цифр;
            int sumDecadesAndUnits = decades + units;
            Console.WriteLine(sumDecadesAndUnits);

            // d.произведение его цифр
            int compositionDecadesAndUnits = decades * units;
            Console.WriteLine(compositionDecadesAndUnits);
            Console.WriteLine();

            // 6.Вычислить значение логического выражения при следующих значениях логических величин А, В и С: А = Истина, В = Ложь, С = Ложь:
            bool A = true;
            bool B = false;
            bool C = false;
            // a.А или В;
            bool AorB = A || B;
            Console.WriteLine(AorB);

            // b.А и В;
            bool AandB = A && B;
            Console.WriteLine(AandB);

            // c.В или С.
            bool BorC = B || C;
            Console.WriteLine(BorC);
            Console.WriteLine();

            // 7.Даны радиус круга и сторона квадрата.У какой фигуры площадь больше ?
            double radius = x.Next() % 10;
            double sideSqare = x.Next() % 10;

            double sqaureOfCircle = radius * radius * 3.14 ;
            double squareOfSquare = sideSqare * sideSqare;
            if (squareOfSquare > sqaureOfCircle) {
                Console.WriteLine("Площадь квдарата больше");
            }
            else
            {
                Console.WriteLine("Площадь круга больше");
            }
            Console.WriteLine();

            // 8.Даны объемы и массы двух тел из разных материалов.Материал какого из тел имеет большую плотность ?
            double volumeFirst = x.Next() % 100;
            double volumeSecond = x.Next() % 100;
            double massFirst = x.Next() % 1000;
            double massSecond = x.Next() % 1000;

            double densityFirst = massFirst / volumeFirst ;
            double densitySecond = massSecond / volumeSecond;
            if (densityFirst > densitySecond)
            {
                Console.WriteLine("Плотность перовго объекта больше");
            }
            else
            {
                Console.WriteLine("Плотность второго объекта больше");
            }
            Console.WriteLine();

            // 9.Известны сопротивления двух несоединенных друг с другом участков электрической цепи и напряжение на каждом из них. 
            // По какому участку протекает меньший ток?
            double resistanceFirst = x.Next() % 10;
            double resistanceSecond = x.Next() % 10;
            double voltageFirst = x.Next() % 110;
            double voltageSecond = x.Next() % 110;

            double amperageFirst = voltageFirst / resistanceFirst;
            double amperageSecond = voltageSecond / resistanceSecond;
            if (amperageFirst > amperageSecond)
            {
                Console.WriteLine("Ток на втором участке меньше");
            }
            else
            {
                Console.WriteLine("Ток на первом участке меньше");
            }
            Console.WriteLine();

            // 10.Напечатать "столбиком":             
            // a.все целые числа от 20 до 35;
            int number = 20;
            while (number != 36)
            {
                Console.WriteLine(number);
                number++;
            }
            Console.WriteLine();

            // b.квадраты всех целых чисел от 10 до b(значение b вводится с клавиатуры; b > 10);
            int newNumber=10;
            int b = Console.Read();
            if (b > 10)
            {
                while (newNumber != b)
                {
                    Console.WriteLine(Math.Pow(newNumber, 2));
                    newNumber++;
                }
            }
            else
            {
                Console.WriteLine("b<10, неверно задано число");
            }
            Console.WriteLine();

            // c.третьи степени всех целых чисел от a до 50(значение a вводится с клавиатуры; a < 50);
            int NumberThree = 50;
            int a = Console.Read();
            if (a < 50)
            {
                while (a != NumberThree)
                {
                    Console.WriteLine(Math.Pow(a, 3));
                    a++;
                }
            }
            else
            {
                Console.WriteLine("a>50, неверно задано число");
            }
            Console.WriteLine();

            // d.все целые числа от a до b(значения a и b вводятся с клавиатуры; b > a).
            a = Console.Read();
            b = Console.Read();
            if (a < b)
            {
                while (a != b)
                {
                    Console.WriteLine(a);
                    a++;
                }
            }
            else
            {
                Console.WriteLine("a>b, неверно задано число");
            }
            Console.WriteLine();
        }
    }
}
