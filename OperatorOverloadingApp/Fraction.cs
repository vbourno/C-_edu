using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingApp
{
    internal class Fraction
    {
        public int Num { get; init; }
        public int Den { get; init; }

        public Fraction(int num, int den) 
        {
            if (den == 0)
            {
                throw new ArgumentException("Denominator cannot be zero");
            }

            Num = num; 
            Den = den;
        }

        public static Fraction operator +(Fraction a) => a;
        public static Fraction operator -(Fraction a) => new Fraction(-a.Num, a.Den);
        public static Fraction operator +(Fraction a, Fraction b) 
            => new(a.Num * b.Den + b.Num * a.Den, a.Den * b.Den);
        public static Fraction operator -(Fraction a, Fraction b)
            => a + (-b);
        public static Fraction operator *(Fraction a, Fraction b)
            => new(a.Num * b.Num, a.Den * b.Den);
        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b.Num == 0)
            {
                throw new DivideByZeroException();
            }

            return new(a.Num * b.Den, a.Den * b.Num);
        }

        public override string ToString()
        {
            return $"{Num} / {Den}";
        }
    }
}
