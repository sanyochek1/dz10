using System;
using System.Collections.Generic;

namespace BankAndBuildingFactory
{
    // Класс здания
    public class Building
    {
        internal string BuildingId { get; private set; }
        internal string Name { get; private set; }

        // Конструктор класса здания
        internal Building(string buildingId, string name)
        {
            BuildingId = buildingId;
            Name = name;
        }
    }

    // Фабрика зданий
    public class BuildingCreator
    {
        private static Dictionary<string, Building> buildings = new Dictionary<string, Building>();

        private BuildingCreator() { } // Закрытый конструктор

        // Метод создания здания
        public static string CreateBuilding(string name)
        {
            string buildingId = GenerateBuildingId();
            var building = new Building(buildingId, name);
            buildings[buildingId] = building;
            return buildingId;
        }

        // Метод для удаления здания
        public static bool RemoveBuilding(string buildingId)
        {
            return buildings.Remove(buildingId);
        }

        // Генерация ID здания
        private static string GenerateBuildingId()
        {
            return Guid.NewGuid().ToString();
        }
    }
}