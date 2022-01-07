using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace Class_17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите числовой номера счета в банке:");
            //int numberInt = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите баланс счета в банке:");
            //int balance = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите ФИО владельца счета в банке:");
            //string name = Console.ReadLine();
            //BankAccount<int> bankAccount1 = new BankAccount<int>(numberInt, balance, name);
            //Console.WriteLine(bankAccount1.GetInfo()); // у экземпляра класса вызываем метод GetInfo для вывода

            //Console.WriteLine();
            //Console.WriteLine("Введите строковый номера счета в банке:");
            //string numberString = Console.ReadLine();
            //Console.WriteLine("Введите баланс счета в банке:");
            //balance = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите ФИО владельца счета в банке:");
            //name = Console.ReadLine();
            //BankAccount<string> bankAccount2 = new BankAccount<string>(numberString, balance, name);
            //Console.WriteLine(bankAccount2.GetInfo());

            BankAccount<int> bankAccount1 = new BankAccount<int>();
            bankAccount1.Input();
            Console.WriteLine(bankAccount1.GetInfo());
            Console.WriteLine();

            BankAccount<string> bankAccount2 = new BankAccount<string>();
            bankAccount2.Input();
            Console.WriteLine(bankAccount2.GetInfo());
            Console.WriteLine();

            Console.ReadKey();
        }
        
    }
    
}
