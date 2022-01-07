using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_17
{
    class BankAccount<T>
    {
        public T NumberAccount { get; set; }  // номер счет
        public int BalanceAccount { get; set; } // баланс счета
        public string Name { get; set; } // ФИО

        //public BankAccount(T number, int balance, string name) // добавляем коструктор , кт принимает 3 значения и заполняет соот-ие св-ва
        //{
        //    NumberAccount = number;
        //    BalanceAccount = balance;
        //    Name = name;
        //}
        public string GetInfo() // метод кт возвращает строку
        {
            return $"{NumberAccount} {BalanceAccount} {Name}";
        }
        public void Input() // метод кт запрашивает значения 
        {
            Console.WriteLine("Введите номера счета в банке:");
            string stringNumber = Console.ReadLine();
            NumberAccount = (T)Convert.ChangeType(stringNumber, typeof(T)); // typeof принимает тип и возвращает информацию, приводит к нужному типу

            Console.WriteLine("Введите баланс счета в банке:");
            BalanceAccount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ФИО владельца счета в банке:");
            Name = Console.ReadLine();

        }
    }
}
