using System;

namespace AljabarLibraries
{
    public class Aljabar
    {
        public static double[] AkarPersamaanKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];
            double c = persamaan[2];

            double D = b * b - 4 * a * c;

            if (D < 0) return new double[] { }; // tidak punya akar real

            double akar1 = (-b + Math.Sqrt(D)) / (2 * a);
            double akar2 = (-b - Math.Sqrt(D)) / (2 * a);

            return new double[] { akar1, akar2 };
        }

        public static double[] HasilKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];

            double A = a * a;
            double B = 2 * a * b;
            double C = b * b;

            return new double[] { A, -B, C }; // -B karena rumus (a - b)^2
        }
    }
}
