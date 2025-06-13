using System;

namespace MatematikaLibraries
{
    public class Matematika
    {
        public int FPB(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public int KPK(int a, int b)
        {
            return (a * b) / FPB(a, b);
        }

        public string Turunan(int[] koef)
        {
            string result = "";
            int pangkat = koef.Length - 1;

            for (int i = 0; i < koef.Length - 1; i++)
            {
                int newKoef = koef[i] * pangkat;
                if (newKoef == 0) { pangkat--; continue; }

                if (result != "" && newKoef > 0)
                    result += " + ";

                result += $"{newKoef}x";
                if (pangkat - 1 > 1)
                    result += $"{pangkat - 1}";
                else if (pangkat - 1 == 1)
                    result += "";

                pangkat--;
            }
            return result;
        }

        public string Integral(int[] koef)
        {
            string result = "";
            int pangkat = koef.Length;

            for (int i = 0; i < koef.Length; i++)
            {
                double newKoef = (double)koef[i] / (pangkat - i);
                if (result != "" && newKoef >= 0)
                    result += " + ";

                result += $"{newKoef}x";
                if ((pangkat - i) != 1)
                    result += $"{pangkat - i}";
            }

            result += " + C";
            return result;
        }
    }
}
