using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccount
{
    /// <summary>
    /// Enum that contains types of the bills.
    /// 1 if Base type of bill, 2 if Gold type, 3 if Platinum type.
    /// </summary>
    [Serializable]
    internal enum TypeOfBill
    {
        Base = 1,
        Gold,
        Platinum,
    }

    /// <summary>
    /// Enum that contains the status of the bill.
    /// 0 if the bill is open, 1 if the bill is closed.
    /// </summary>
    /// [Serializable]
    internal enum IsClosed
    {
        Open,
        Closed,
    }

    /// <summary>
    /// Describes bank account.
    /// </summary>
    [Serializable]
    internal abstract class BankAccount
    {
        protected long billNumber;
        protected double billBonuse;
        protected OwnerInfo owner;
        protected List<double> bills = new List<double>();
        protected IsClosed isClosed;
        protected TypeOfBill type;
        private Storage billStorage = new Storage();

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccount"/> class.
        /// Constructor of the class.
        /// </summary>
        /// <param name="firstName">First name of the owner of the account.</param>
        /// <param name="lastName">Last name of the owner of the account.</param>
        /// <param name="billNumber">The number of the bill.</param>
        /// <param name="billBalance">The balance of the bill.</param>
        /// <param name="typeOfBill">Type of the bill.</param>
        public BankAccount(string firstName, string lastName, long billNumber, double billBalance, TypeOfBill typeOfBill)
        {
            this.owner = new OwnerInfo() { FirstName = firstName, LastName = lastName };
            if (billNumber.ToString().Length != 16)
            {
                throw new ArgumentException("Bill number should contain 16 digits.");
            }
            else
            {
                this.billNumber = billNumber;
            }

            if (billBalance < 0)
            {
                throw new ArgumentException("Bill balance can't be less than zero.");
            }
            else
            {
                this.bills.Add(billBalance);
            }

            this.type = typeOfBill;
            this.isClosed = IsClosed.Open;
            this.billStorage.AddBillToStorage(this);
        }

        /// <summary>
        /// Adds new bill.
        /// </summary>
        /// <param name="sum">Start sum of new bill.</param>
        public void AddNewBill(double sum)
        {
            if (sum > 0)
            {
                this.bills.Add(sum);
            }
            else
            {
                throw new ArgumentException("Start sum of the bill can't be less than zero.");
            }
        }

        /// <summary>
        /// Closes existing bill.
        /// </summary>
        /// <param name="indexOfBill">Index of the bill.</param>
        public void CloseExistingBill(int indexOfBill)
        {
            if (this.bills[indexOfBill] < 0)
            {
                throw new ArgumentException("You can't close the bill with negative balance.");
            }

            this.isClosed = IsClosed.Closed;
            Console.WriteLine("The bill is closed.\n");
        }

        /// <summary>
        /// Makes string representation of account.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return $"Bill number:{this.billNumber}\nBill balance:{this.bills.ToArray().Sum()}\nType:{this.type}\nStatus:{this.isClosed.ToString()}\n";
        }

        /// <summary>
        /// Withdraw amount of money from the bill.
        /// </summary>
        /// <param name="sum">Amount of money to withdraw from the bill.</param>
        /// <param name="indexOfBill">Index of the bill.</param>
        protected void WithdrawAmount(double sum, int indexOfBill)
        {
            if (this.isClosed == IsClosed.Closed)
            {
                throw new ArgumentException("The bill is closed. You can't withdraw amount from it.");
            }
            else
            {
                this.bills[indexOfBill] -= sum;
            }
        }

        /// <summary>
        /// Method for putting amount of money to the bill.
        /// </summary>
        /// <param name="sum">Amount of money to put to the bill.</param>
        /// <param name="indexOfBill">Index of the bill.</param>
        protected abstract void PutAmount(double sum, int indexOfBill);
    }
}
