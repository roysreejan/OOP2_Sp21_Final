using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task_2_Bank_
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account("Sreejan", "19397371", 50000);
            Account a2 = new Account("Roy", "19397372", 40000);
            a1.Withdraw(500);
            a1.Deposit(1000);
            a1.Transfer(a2,1000);
            a1.ShowInfo();
            a2.ShowInfo();
        }
    }
}
