using System;
using System.Collections.Generic;

namespace BankAndBuildingFactory
{
    // Класс банковского счета
    public class BankAccount
    {
        internal string AccountNumber { get; private set; }
        internal decimal Balance { get; private set; }

        // Конструктор класса банковского счета
        internal BankAccount(string accountNumber, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }
    }

    // Фабрика банковских счетов
    public class AccountFactory
    {
        private static Dictionary<string, BankAccount> accounts = new Dictionary<string, BankAccount>();

        // Метод создания счета с начальным балансом
        public static string CreateAccount(decimal initialBalance)
        {
            string accountNumber = GenerateAccountNumber();
            var account = new BankAccount(accountNumber, initialBalance);
            accounts[accountNumber] = account;
            return accountNumber;
        }

        // Перегрузка метода создания счета с номером
        public static string CreateAccount(string accountNumber, decimal initialBalance)
        {
            var account = new BankAccount(accountNumber, initialBalance);
            accounts[accountNumber] = account;
            return accountNumber;
        }

        // Метод для закрытия счета
        public static bool CloseAccount(string accountNumber)
        {
            return accounts.Remove(accountNumber);
        }

        // Генерация номера счета
        private static string GenerateAccountNumber()
        {
            return Guid.NewGuid().ToString();
        }
    }
}