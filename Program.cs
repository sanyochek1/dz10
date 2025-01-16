using System;

namespace BankAndBuildingFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Тестирование банковских счетов
            Console.WriteLine("Задача 11.1:");
            Console.WriteLine("Создание банковского счета.");
            Console.WriteLine("Введите начальный баланс:");
            decimal initialBalance = Convert.ToDecimal(Console.ReadLine());
            string accountNumber = AccountFactory.CreateAccount(initialBalance);
            Console.WriteLine($"Создан банковский счет с номером: {accountNumber}");

            // Закрытие счета
            Console.WriteLine("Закрытие счета. Введите номер счета для закрытия:");
            string closeAccountNumber = Console.ReadLine();
            if (AccountFactory.CloseAccount(closeAccountNumber))
            {
                Console.WriteLine($"Счет {closeAccountNumber} успешно закрыт.");
            }
            else
            {
                Console.WriteLine($"Не удалось закрыть счет {closeAccountNumber}.");
            }

            // Тестирование создания зданий
            Console.WriteLine("Задача 11.2:");
            Console.WriteLine("Создание здания.");
            string buildingId = BuildingCreator.CreateBuilding("Новое здание");
            Console.WriteLine($"Создано здание с ID: {buildingId}");

            // Удаление здания
            Console.WriteLine("Удаление здания. Введите ID здания для удаления:");
            string removeBuildingId = Console.ReadLine();
            if (BuildingCreator.RemoveBuilding(removeBuildingId))
            {
                Console.WriteLine($"Здание {removeBuildingId} успешно удалено.");
            }
            else
            {
                Console.WriteLine($"Не удалось удалить здание {removeBuildingId}.");
            }
        }
    }
}