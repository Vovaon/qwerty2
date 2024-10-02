using System;

namespace GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор площ геометричних фiгур");

            while (true)
            {
                Console.WriteLine("\nОберiть фiгуру:");
                Console.WriteLine("1. Прямокутник");
                Console.WriteLine("2. Квадрат");
                Console.WriteLine("3. Трикутник");
                Console.WriteLine("4. Ромб");
                Console.WriteLine("5. Коло");
                Console.WriteLine("0. Вихiд");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CalculateRectangleArea();
                        break;
                    case 2:
                        CalculateSquareArea();
                        break;
                    case 3:
                        CalculateTriangleArea();
                        break;
                    case 4:
                        CalculateRhombusArea();
                        break;
                    case 5:
                        CalculateCircleArea();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Некоректний вибiр.");
                        break;
                }
            }
        }

        static void CalculateRectangleArea()
        {
            Console.Write("Введiть довжину прямокутника: ");
            double length = GetPositiveNumber();
            Console.Write("Введiть ширину прямокутника: ");
            double width = GetPositiveNumber();
            double area = length * width;
            Console.WriteLine($"Площа прямокутника: {area}");
        }

        static void CalculateSquareArea()
        {
            Console.Write("Введiть сторону квадрата: ");
            double side = GetPositiveNumber();
            double area = side * side;
            Console.WriteLine($"Площа квадрата: {area}");
        }

        static void CalculateTriangleArea()
        {
            Console.Write("Введiть основу трикутника: ");
            double baseLength = GetPositiveNumber();
            Console.Write("Введiть висоту трикутника: ");
            double height = GetPositiveNumber();
            double area = 0.5 * baseLength * height;
            Console.WriteLine($"Площа трикутника: {area}");
        }

        static void CalculateRhombusArea()
        {
            Console.Write("Введiть першу дiагональ ромба: ");
            double diagonal1 = GetPositiveNumber();
            Console.Write("Введiть другу дiагональ ромба: ");
            double diagonal2 = GetPositiveNumber();
            double area = 0.5 * diagonal1 * diagonal2;
            Console.WriteLine($"Площа ромба: {area}");
        }

        static void CalculateCircleArea()
        {
            Console.Write("Введiть радiус кола: ");
            double radius = GetPositiveNumber();
            double area = Math.PI * radius * radius;
            Console.WriteLine($"Площа кола: {area}");
        }

        static double GetPositiveNumber()
        {
            double number;
            while (!double.TryParse(Console.ReadLine(), out number) || number <= 0)
            {
                Console.WriteLine("Будь ласка, введiть додатне число:");
            }
            return number;
        }
    }
}