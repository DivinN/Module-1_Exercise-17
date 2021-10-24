using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1_Exercise_17_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сегодня играем в банк!");
            BankAccount<int> acc1 = new BankAccount<int>();
            
            Console.WriteLine("Создадим первый счет (у него поле номера будет в integer). Пожалуйста, введите номер первого счета.");
            int acc1Number = Convert.ToInt32(Console.ReadLine());
            acc1.SetAccountNumber(acc1Number);
            
            Console.WriteLine("Введите баланс первого счета.");
            int acc1Balance = Convert.ToInt32(Console.ReadLine());
            acc1.SetAccountBalance(acc1Balance);
            
            Console.WriteLine("Введите ФИО владельца первого счета.");
            string acc1OwnerName = Console.ReadLine();
            acc1.SetOwnerName(acc1OwnerName);


            Console.WriteLine("Создадим второй счет (у него поле номера будет в string). Пожалуйста, введите номер второго счета.");
            BankAccount<string> acc2 = new BankAccount<string>();
            string acc2Number = Console.ReadLine();
            acc2.SetAccountNumber(acc2Number);

            Console.WriteLine("Введите баланс второго счета.");
            int acc2Balance = Convert.ToInt32(Console.ReadLine());
            acc2.SetAccountBalance(acc2Balance);

            Console.WriteLine("Введите ФИО владельца второго счета.");
            string acc2OwnerName = Console.ReadLine();
            acc2.SetOwnerName(acc2OwnerName);


            Console.WriteLine("Итак, первый счет - номер: {0}, баланс: {1}, ФИО владельца: {2}.", acc1.GetAccountNumber(), acc1.GetAccountBalance(), acc1.GetOwnerName());
            Console.WriteLine("А теперь второй счет - номер: {0}, баланс: {1}, ФИО владельца: {2}.", acc2.GetAccountNumber(), acc2.GetAccountBalance(), acc2.GetOwnerName());
            Console.ReadKey();
        }

        class BankAccount <T>
        {
            static T accountNumber;
            static int accountBalance;
            static string ownerName;

            public void SetAccountNumber(T value)
            {
                accountNumber = value;
            }
            public T GetAccountNumber()
            {
                return accountNumber;
            }
            public void SetAccountBalance(int value)
            {
                accountBalance = value;
            }
            public int GetAccountBalance()
            {
                return accountBalance;
            }
            public void SetOwnerName(string value)
            {
                ownerName = value;
            }
            public string GetOwnerName()
            {
                return ownerName;
            }
        }
    }
}
