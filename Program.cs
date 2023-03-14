using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Введите размерность N: ");
        int N = int.Parse(Console.ReadLine());

        double[] point1 = new double[N];
        Console.WriteLine("Введите координаты первой точки:");
        for (int i = 0; i < N; i++) {
            Console.Write("координата {0}: ", i + 1);
            point1[i] = double.Parse(Console.ReadLine());
        }

        double[] point2 = new double[N];
        Console.WriteLine("Введите координаты второй точки:");
        for (int i = 0; i < N; i++) {
            Console.Write("координата {0}: ", i + 1);
            point2[i] = double.Parse(Console.ReadLine());
        }

        double sumOfSquares = 0;
        for (int i = 0; i < N; i++) {
            double diff = point1[i] - point2[i];
            sumOfSquares += diff * diff;
        }
        double distance = Math.Sqrt(sumOfSquares);

        Console.WriteLine("Расстояние между точками: {0}", distance);
    }
}

