using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FractionMath
{
    class MixedFraction : Fraction
    {
        // These are member variables
        private int mWhole, mNumerator, mDenominator;

        // Constructor if no input values are given
        public MixedFraction() : base() //use the base constructor of the fraction class as well
        {
            mWhole = 0;
        }

        // Constructor if all three parameters are passed in.
        // Call a static method tot create values for pass to the base costructor.
        // the vase costructor.
        // Turn into an improper fraction.
        public MixedFraction(int wh1, int num, int denom) :
            base(CreateImproperNumerator(wh1, num, denom), Math.Abs(denom)) // base(modifiedNum, modifiedDemon)
        {
            mWhole = 0;
        }

        private static int CreateImproperNumerator(int wh1, int num, int denom)
        {
            int sign = 1;
            if (wh1 < 0)
            {
                sign *= -1;
                wh1 *= -1;
            }
            if (num < 0)
            {
                sign *= -1;
                num *= -1;
            }
            if (denom < 0)
            {
                sign *= -1;
                denom *= -1;
            }

            num = sign * ((wh1 * denom) + num);
            return num;

        }

        public int GetmWhole()
        {
            return mWhole;
        }

        public int GetmNumerator()
        {
            return mNumerator;
        }

        public int GetmDenominator()
        {
            return mDenominator;
        }

        public void ToMixedFraction(Fraction impFraction)
        {
            mWhole = impFraction.GetNumerator() / impFraction.GetDenominator();

            mNumerator = impFraction.GetNumerator() % impFraction.GetDenominator();

            if (mWhole < 0)
            {// strip the negative off the numerator if the whole is negative
                mNumerator = Math.Abs(mNumerator);
            }

            mDenominator = impFraction.GetDenominator();
            if (mNumerator == 0)
            {
                mDenominator = 1;
            }
        }

        public string GetmString()
        { // need to code this
            return Convert.ToString(this.GetmWhole()) + " " +
                   Convert.ToString(this.GetmNumerator()) + " / " +
                   Convert.ToString(this.GetmDenominator());
        }
    }
}
