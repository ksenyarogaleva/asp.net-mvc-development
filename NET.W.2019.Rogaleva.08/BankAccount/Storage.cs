using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BankAccount
{
    /// <summary>
    /// Organizes the storage of bank acconts in binary file.
    /// </summary>
    [Serializable]
    internal class Storage
    {
        private static string pathToStorage="test.txt";
        private static List<BankAccount> allBills = new List<BankAccount>();

        /// <summary>
        /// Gets property for list of bank accounts.
        /// </summary>
        public static List<BankAccount> AllBills => allBills;

        /// <summary>
        /// Adds bank account to the binary file.
        /// </summary>
        /// <param name="bankAccount">Bank account to save in binary file.</param>
        public void AddBillToStorage(BankAccount bankAccount)
        {
            if (allBills.Contains(bankAccount))
            {
                throw new ArgumentException("This bill has already been added to storage.");
            }
            else
            {
                allBills.Add(bankAccount);
                this.SaveBillToStorage();
            }
        }

        /// <summary>
        /// Loads existing bank accounts from binary file and adds it to the list of bank accounts.
        /// </summary>
        public void LoadBillFromStorage()
        {
            if (File.Exists(pathToStorage))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fileStream = new FileStream(pathToStorage, FileMode.Open))
                {
                    allBills = (List<BankAccount>)formatter.Deserialize(fileStream);
                    Console.WriteLine("Bills are loaded");
                }
            }
        }

        /// <summary>
        /// Saves bank accounts from the list of bank accounts to the binary file.
        /// </summary>
        public void SaveBillToStorage()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fileStream = new FileStream(pathToStorage, FileMode.Create))
            {
                formatter.Serialize(fileStream, allBills);
                Console.WriteLine("Bills are saved");
            }
        }
    }
}
