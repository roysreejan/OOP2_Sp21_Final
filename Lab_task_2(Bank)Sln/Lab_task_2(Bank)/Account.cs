using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task_2_Bank_
{
    class Account
    {
        public string AccName { get; set; }
        public string AccNo { get; }
        public int Balance { get; set; }
        public int TotalNumberofTransaction{get; set; }

        private Transaction[] listOfTransaction;

        public Account() 
        {
            listOfTransaction = new Transaction[10];
        }
        public Account(string accName, string accNo, int balance)
        {
            AccName = accName;
            AccNo = accNo;
            Balance = balance;
            listOfTransaction = new Transaction[10];
        }
        public void Deposit(int amount)
        {
            Balance += amount;
            Console.WriteLine("Deposit successfull.");
            Transaction tr = new Transaction(this, this, amount, "Self Deposit");
            this.AddTransaction(tr);
        }
        public void Withdraw(int amount)
        {
            if (amount <= Balance)
            {
                Balance = Balance - amount;
                Console.WriteLine("Withdraw successfull.");
                Transaction tr = new Transaction(this, this, amount, "Self Withdraw");
                this.AddTransaction(tr);
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }
        public void Transfer(Account acc, int amount )
        {
            if (Balance - amount >= 0)
            {
                Balance = Balance - amount;
                acc.Balance = acc.Balance + amount;
                Console.WriteLine("Balance Transfered.");
                Transaction tr = new Transaction(this, acc, amount, "Money Transfer");
                this.AddTransaction(tr);
                acc.AddTransaction(tr);
            }
            else
            {
                Console.WriteLine("Transfer failed");
            }
        }
        public void AddTransaction(Transaction tr)
        {
            if (this.TotalNumberofTransaction < 10)
            {
                listOfTransaction[TotalNumberofTransaction++] = tr;
            }
        }
        public void ShowAllTransaction()
        {
            for (int i = 0; i < (TotalNumberofTransaction + 1); i++)
            {
                listOfTransaction[i].ShowInfo();
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("Acc Name: {0}", AccName);
            Console.WriteLine("Acc No: {0}", AccNo);
            Console.WriteLine("Balance: {0}", Balance);
        }
    }
}
