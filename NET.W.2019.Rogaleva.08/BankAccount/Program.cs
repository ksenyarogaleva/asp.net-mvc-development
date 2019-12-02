using System;

namespace BankAccount
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            GoldBill bill = new GoldBill("Kseniya", "Rogaleva", 1017654902347980, 100M);
            PlatinumBill bill1 = new PlatinumBill("Stepkina", "Svetlana", 2086392902347919, 1230M);
            BaseBill bill2 = new BaseBill("Morozova", "Ekaterina", 7895652902347919, 600M);
            bill.AddNewBill(3720M);
            foreach (BankAccount acc in Storage.AllBills)
            {
                Console.WriteLine(acc.ToString());
            }

            bill.CloseExistingBill(0);
            foreach (BankAccount acc in Storage.AllBills)
            {
                Console.WriteLine(acc.ToString());
            }

            Console.ReadKey();
        }
    }
}
