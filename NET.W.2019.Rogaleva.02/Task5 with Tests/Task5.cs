using System;

namespace Tasks
{

    /// <summary>
    /// The main <c>Task5</c> class.
    /// Contains realization of Newton's method of finding Nth root.
    /// </summary>
    public class Task5
    {
        /// <summary>
        /// Finds Nth root.
        /// </summary>
        /// <param name="number">Number to find its root.</param>
        /// <param name="rootDegree">Root degree of a number.</param>
        /// <param name="accuracy">Accuracy.</param>
        /// <returns>Nth root of a number that was found.</returns>
        public static double FindNthRoot(double number, int rootDegree, double accuracy)
        {
            CheckInput(number, rootDegree, accuracy);
            double root = number / rootDegree;
            double resultRoot = NewtonMethod(rootDegree, number, root);

            while (Math.Abs(resultRoot - root) > accuracy)
            {
                root = resultRoot;
                resultRoot = NewtonMethod(rootDegree, number, root);
            }
            return resultRoot;
        }

        /// <summary>
        /// Checks input parameters.
        /// </summary>
        /// <param name="n">Number.</param>
        /// <param name="i">Root degree of a number.</param>
        /// <param name="acc">Accuracy.</param>
        public static void CheckInput(double n, int i, double acc)
        {
            if (acc < 0) throw new ArgumentOutOfRangeException("Accuracy can't be < 0");
            if (i <= 0 || n <= 0 & i % 2 == 0) throw new ArgumentOutOfRangeException("Number can't be < 0");
        }

        /// <summary>
        /// Applies Newton's formula.
        /// </summary>
        /// <param name="degree">Root degree of a number.</param>
        /// <param name="num">Number to find its root.</param>
        /// <param name="root">Temporary value of a root.</param>
        /// <returns></returns>
        public static double NewtonMethod(int degree, double num, double root)
        {
            return 1.0 / degree * ((degree - 1) * root + num / Math.Pow(root, degree - 1));
        }
    }
}
