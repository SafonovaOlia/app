using System;

namespace task21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите координаты x1 точки А: ");
            Double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координаты y2 точки А: ");
            Double y2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координаты z1 точки А: ");
            Double z1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координаты x2 точки В: ");
            Double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координаты y1 точки В: ");
            Double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координаты z2 точки В: ");
            Double z2 = Convert.ToDouble(Console.ReadLine());

            double Decision(double Dx1, double Dx2, double Dy1, double Dy2, double Dz1, double Dz2)
            {
                return Math.Sqrt(Math.Pow((Dx2-Dx1), 2) + Math.Pow((Dy2-Dy1), 2) + Math.Pow((Dz2-Dz1), 2));
            }
            double distance =  Math.Round(Decision(x1, x2, y1, y2, z1, z2), 2 );
            Console.WriteLine($"расстояние между двумя точками в 3D пространстве: {distance}");
        }
    }
}
