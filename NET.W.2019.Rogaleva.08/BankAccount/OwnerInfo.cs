using System;

namespace BankAccount
{
    [Serializable]
    internal class OwnerInfo
    {
        private string lastName;
        private string firstName;

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value ?? throw new ArgumentNullException(nameof(value)); }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value ?? throw new ArgumentNullException(nameof(value)); }
        }
    }
}
