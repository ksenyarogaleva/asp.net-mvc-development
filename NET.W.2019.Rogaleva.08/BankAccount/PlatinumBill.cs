using System;

namespace BankAccount
{
    /// <summary>
    /// Class that represents Platinum bill.
    /// </summary>
    [Serializable]
    internal class PlatinumBill : BankAccount
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlatinumBill"/> class.
        /// </summary>
        /// <param name="firstName">First name of the owner of the bill.</param>
        /// <param name="lastName">Last name of the owner of the bill.</param>
        /// <param name="billNumber">The number of the bill.</param>
        /// <param name="billBalance">The balance of the bill.</param>
        public PlatinumBill(string firstName, string lastName, long billNumber, double billBalance)
            : base(firstName, lastName, billNumber, billBalance, TypeOfBill.Platinum)
        {
        }

        /// <summary>
        /// Method for outting amount of money to the Platinum bill.
        /// </summary>
        /// <param name="sum">Amount of money to put to the bill.</param>
        /// <param name="indexOfBill">Index of the bill.</param>
        protected override void PutAmount(double sum, int indexOfBill)
        {
            if (this.isClosed == IsClosed.Closed)
            {
                throw new ArgumentException("The bill is closed. You can't put amount.");
            }
            else
            {
                this.bills[indexOfBill] += sum;
                this.billBonuse += (int)TypeOfBill.Platinum * sum / 100;
            }
        }
    }
}
