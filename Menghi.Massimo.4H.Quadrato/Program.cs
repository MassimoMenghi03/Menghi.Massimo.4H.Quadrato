using System;

namespace Menghi.Massimo._4H.Quadrato
{
    class Program
    {
        static void Main(string[] args)
        {
            Q Q1 = new Q(10, 70, 140);
            Q Q2 = new Q(11, 120, 130);

            Console.WriteLine($"Le aree dei due quadrati sono {Q1.Area()} e {Q2.Area()}");

            Console.WriteLine("I perimetri dei due quadrati sono {0} e {1}", Q1.Perimetro(), Q2.Perimetro());

            Console.WriteLine("Le diagonali dei due quadrati sono {0} e {1}", Q1.Diagonale(), Q2.Diagonale());

            if (Q1 > Q2)
            {
                Console.WriteLine("Più grande il primo quadrato");
            }
            else
            {
                Console.WriteLine("Più grande il secondo quadrato ");
            }
        }
    }

    class Q
    {
        double _lato;
        int _posx;
        int _posy;


        public double L
        {
            get; set;
        }

        public int X
        {
            get; set;
        }

        public int Y
        {
            get; set;
        }

        public Q(double lato, int posx, int posy)
        {
            L = lato;
            X = posx;
            Y = posy;
        }

        public double Area()
        {
            return Math.Pow(L, 2);
        }

        public double Perimetro()
        {
            return L * 4;
        }

        public double Diagonale()
        {
            return Math.Sqrt(2 * L * L);
        }

        public static bool operator >(Q Q1, Q Q2)
        {
            if (Q1.Area() > Q2.Area())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(Q Q1, Q Q2)
        {
            if (Q1.Area() > Q2.Area())
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}