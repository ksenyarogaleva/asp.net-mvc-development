using System;
using System.Text;

namespace PolynomialClass
{
    /// <summary>
    /// The main <c>Polynomial</c> class.
    /// Polynomial class for working with polynoms.
    /// </summary>
    public sealed class Polynomial
    {
        private readonly double[] odds;

        /// <summary>
        /// Property for odd's indexes.
        /// </summary>
        /// <param name="indexOfOdd">Odd's index.</param>
        /// <returns>Array of polynoms.</returns>
        public double this[int indexOfOdd]
        {
            get
            {
                if (indexOfOdd < 0)
                {
                    throw new ArgumentException("Error! The length of thearray can't be negative");
                }

                if (indexOfOdd > this.odds.Length - 1)
                {
                    return 0;
                }

                return this.odds[indexOfOdd];
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Polynomial"/> class.
        /// Constructor of class <c>Polynomial</c>.
        /// </summary>
        /// <param name="array">Array of polynoms.</param>
        public Polynomial(params double[] array)
        {
            this.odds = array ?? throw new ArgumentException("Error!Array is null.");
        }

        /// <summary>
        /// Provides string representation of polynomial array.
        /// </summary>
        /// <returns>String representation of the array.</returns>
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            for (int i = 0; i < this.odds.Length; i++)
            {
                if (this.odds[i] != 0)
                {
                    if (i == 0)
                    {
                        str.Append(this.odds[i]);
                        continue;
                    }

                    if (i > 0 && str.Length > 0)
                    {
                        if (this.odds[i] > 0)
                        {
                            str.Append($" + {this.odds[i]}^{i}");
                        }

                        if (this.odds[i] < 0)
                        {
                            str.Append($" - {Math.Abs(this.odds[i])}^{i}");
                        }
                    }
                    else
                    {
                        str.Append($"{this.odds[i]}^{i}");
                    }
                }
            }

            return str.ToString();
        }

        /// <summary>
        /// Determins the equivalence of the object to the polynomial.
        /// </summary>
        /// <param name="obj">Object to determin its equivalence.</param>
        /// <returns>The result of the determination.</returns>
        public override bool Equals(object obj)
        {
            if (obj is null)
            {
                return false;
            }

            if (this.GetType() != obj.GetType())
            {
                return false;
            }

            return this.Equals(obj as Polynomial);
        }

        /// <summary>
        /// Determins the equivalence of two polynomials.
        /// </summary>
        /// <param name="p">Polynomial.</param>
        /// <returns>The result of the determination.</returns>
        public bool Equals(Polynomial p)
        {
            if (p == null)
            {
                return false;
            }

            if (this.GetHashCode() != p.GetHashCode())
            {
                return false;
            }

            for (int i = 0; i < this.odds.Length; i++)
            {
                if (this.odds[i] != p.odds[i])
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Calculates hash code of the polynomial.
        /// </summary>
        /// <returns>The hash code of the polynomial.</returns>
        public override int GetHashCode()
        {
            double hashCode = 1;
            int count = 1;
            foreach (double odd in this.odds)
            {
                hashCode += odd;
                hashCode *= count;
                count++;
            }

            return (int)hashCode;
        }

        #pragma warning disable SA1201 // Elements should appear in the correct order
        /// <summary>
        /// Calculates the sum of two polynomials.
        /// </summary>
        /// <param name="left">First polynomial.</param>
        /// <param name="right">Second Polynomial.</param>
        /// <returns>The sum of two polynomials.</returns>
        public static Polynomial operator +(Polynomial left, Polynomial right)
        {
            CheckTheArray(left);
            CheckTheArray(right);

            int minLength = left.odds.Length < right.odds.Length ? left.odds.Length : right.odds.Length;
            int maxLength;
            if (minLength == right.odds.Length)
            {
                 maxLength = left.odds.Length;
            }
            else
            {
                 maxLength = right.odds.Length;
            }

            double[] added = new double[maxLength];
            for (int i = 0; i < minLength; i++)
            {
                added[i] = left.odds[i] + right.odds[i];
            }

            for (int i = minLength; i < maxLength; i++)
            {
                if (maxLength == right.odds.Length)
                {
                    added[i] = right.odds[i];
                }
                else
                {
                    added[i] = left.odds[i];
                }
            }

            return new Polynomial(added);
        }

#pragma warning restore SA1201 // Elements should appear in the correct order
        /// <summary>
        /// Calculates the difference of two polynomials.
        /// </summary>
        /// <param name="left">First polynomial.</param>
        /// <param name="right">Second polynomial.</param>
        /// <returns>The difference between two polynomials.</returns>
        public static Polynomial operator -(Polynomial left, Polynomial right)
        {
            CheckTheArray(left);
            CheckTheArray(right);

            int minLength = left.odds.Length < right.odds.Length ? left.odds.Length : right.odds.Length;
            int maxLength;
            if (minLength == right.odds.Length)
            {
                maxLength = left.odds.Length;
            }
            else
            {
                maxLength = right.odds.Length;
            }

            double[] substracted = new double[maxLength];
            for (int i = 0; i < minLength; i++)
            {
                substracted[i] = left[i] - right[i];
            }

            for (int i = minLength; i < maxLength; i++)
            {
                if (maxLength == right.odds.Length)
                {
                    substracted[i] = -right.odds[i];
                }
                else
                {
                    substracted[i] = -left.odds[i];
                }
            }

            return new Polynomial(substracted);
        }

        /// <summary>
        /// Calculates the composition of two polynomials.
        /// </summary>
        /// <param name="left">First polynomial.</param>
        /// <param name="right">Second polynomial.</param>
        /// <returns>The composition of two polynomials.</returns>
        public static Polynomial operator *(Polynomial left, Polynomial right)
        {
            CheckTheArray(left);
            CheckTheArray(right);
            int maxLength = left.odds.Length + right.odds.Length - 1;
            double[] multiplied = new double[maxLength];
            for (int i = 0; i < left.odds.Length; i++)
            {
                for (int j = 0; j < right.odds.Length; j++)
                {
                    multiplied[i + j] += left.odds[i] * right.odds[j];
                }
            }

            return new Polynomial(multiplied);
        }

        /// <summary>
        /// Compares two polynomials.
        /// </summary>
        /// <param name="left">First polynomial.</param>
        /// <param name="right">Second polynomial.</param>
        /// <returns>'True' if polynomials are equal.</returns>
        public static bool operator ==(Polynomial left,Polynomial right)
        {
            CheckTheArray(left);
            CheckTheArray(right);
            if (left.odds.Length != right.odds.Length)
            {
                return false;
            }

            for (int i = 0; i < left.odds.Length; i++)
            {
                if (left.odds[i] != right.odds[i])
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Compares two polynomials.
        /// </summary>
        /// <param name="left">First polynomial.</param>
        /// <param name="right">Second polynomial.</param>
        /// <returns>'True' of polynomials are not equal.</returns>
        public static bool operator !=(Polynomial left, Polynomial right)
        {
            return !(left == right);
        }

        public static void CheckTheArray(Polynomial polynomial)
        {
            if (polynomial == null)
            {
                throw new ArgumentException("Instance acn't be null.");
            }
        }
    }
}
