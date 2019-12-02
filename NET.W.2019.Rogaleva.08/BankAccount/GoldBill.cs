using System;

namespace BankAccount
{
    /// <summary>
    /// Class that represents Gold bill.
    /// </summary>
    [Serializable]
    internal class GoldBill : BankAccount
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoldBill"/> class.
        /// </summary>
        /// <param name="firstName">First name of the owner of the bill.</param>
        /// <param name="lastName">Last name of the owner of the bill.</param>
        /// <param name="billNumber">The number of the bill.</param>
        /// <param name="billBalance">The balance of the bill.</param>
        public GoldBill(string firstName, string lastName, long billNumber, decimal billBalance)
            : base(firstName, lastName, billNumber, billBalance, TypeOfBill.Gold)
        {
        }

        /// <summary>
        /// Method for outting amount of money to the Gold bill.
        /// </summary>
        /// <param name="sum">Amount of money to put to the bill.</param>
        /// <param name="indexOfBill">Index of the bill.</param>
        protected override void PutAmount(decimal sum, int indexOfBill)
        {
            if (this.isClosed == IsClosed.Closed)
            {
                throw new ArgumentException("The bill is closed. You can't put amount.");
            }
            else
            {
                this.bills[indexOfBill] += sum;
                this.billBonuse += (int)TypeOfBill.Gold * sum / 100;
            }
        }
    }
}
