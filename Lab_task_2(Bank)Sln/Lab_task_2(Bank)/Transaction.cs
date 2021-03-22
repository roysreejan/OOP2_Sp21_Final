using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task_2_Bank_
{
    class Transaction
    {
        public Account Sender { get; set; }
        public Account Receiver { get; set; }
        public int Amount { get; set; }
        public string AdditionalInfo { get; set; }

        public Transaction() { }
        public Transaction(Account sender, Account receiver, int amount, string additionalInfo)
        {
            Sender = sender;
            Receiver = receiver;
            Amount = amount;
            AdditionalInfo = additionalInfo;
        }
        
        public void ShowInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Sender Name: {0}\nAccount no: {1}",Sender.AccName, Sender.AccNo);
            Console.WriteLine("Receiver Name: {0}\nAccount no: {1}",Receiver.AccName, Receiver.AccNo);
            Console.WriteLine("Account Amount: {0}",Amount);
            Console.WriteLine("Account Additonal Info: {0}",AdditionalInfo);
        }
    }
}
