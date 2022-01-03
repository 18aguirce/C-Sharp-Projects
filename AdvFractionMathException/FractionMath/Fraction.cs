using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FractionMath
{
    class Fraction
    {
        // These are called member variables. no need to make it public
        private int numerator, denominator;

        // This is called the default constructor. it DOESN'T    RETURN ANYTHING AND TAKES NO PARAMETERS.
        public Fraction()
        {
            numerator = 0;
            denominator = 1;
        }

        // This is an overload constructor.
        public Fraction(int num, int denom)
        {
            this.numerator = num;
            this.denominator = denom;
            Reduce();
        }

        public int GetNumerator()
        {
            return numerator;
        }

        public int GetDenominator()
        {
            return denominator;
        }

        // This is a private 'helper method'
        private void Reduce()
        {
            int sign = 1;
            if (numerator < 0)
            {
                sign *= -1;
                numerator *= -1;
            }
            if (denominator < 0)
            {
                sign *= -1;
                denominator *= -1;
            }

            for (int i = numerator; i > 1; i--)
            {
                if (numerator % i == 0 && denominator % i == 0)
                {
                    // If this is true, found the biggest number on top and bottom
                    // that is evenly divisible.
                    numerator /= i; // numerator = numerator /i
                    denominator /= i;
                    break;
                }

                numerator *= sign;
            } // End Reduce()
        }

        // Example of old school way if operator overload is not available.
        public Fraction Add(Fraction fraction1, Fraction fraction2)
        {
            this.numerator = (fraction1.numerator * fraction2.denominator)
                + (fraction1.denominator * fraction2.numerator);
            this.denominator = fraction1.denominator * fraction2.denominator;

            this.Reduce();
            return this;
        }

        // example of operator overload method.
        public static Fraction operator +(Fraction fraction1, Fraction fraction2)
        {
            Fraction result = new Fraction();

            result.numerator = (fraction1.numerator * fraction2.denominator) + (fraction1.denominator * fraction2.numerator);
            result.denominator = fraction1.denominator * fraction2.denominator;

            result.Reduce();
            return result;

        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            Fraction result = new Fraction();

            result.numerator = (f1.numerator * f2.denominator) - (f1.denominator * f2.numerator);
            result.denominator = f1.denominator * f2.denominator;

            result.Reduce();
            return result;
        }

        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            Fraction result = new Fraction();

            result.numerator = f1.numerator * f2.numerator;
            result.denominator = f1.denominator * f2.denominator;

            result.Reduce();
            return result;
        }

        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            Fraction result = new Fraction();

            result.numerator = f1.numerator * f2.denominator;
            result.denominator = f1.denominator * f2.numerator;

            result.Reduce();
            return result;
        }

        // fraction to string
        public string GetString()
        {
            return Convert.ToString(this.GetNumerator()) + " / "
                + Convert.ToString(this.GetDenominator());
        }

    }
}
