using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_13._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Франкфурта_17", 500, 345, 123);
            MultiBuilding multiBuilding = new MultiBuilding("Герасименко_45", 234, 34564, 363, 9);
            building.print();
            multiBuilding.print();
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
    class Building
    {
        public string buildingAddress { get; set; }//свойства
        public double buildingLength { get; set; }
        public double buildingWeight { get; set; }
        public double buildingHeight { get; set; }
        public Building(string buildingAddress, double buildingLength, double buildingWeight, double buildingHeight)
        {
            this.buildingAddress = buildingAddress;
            this.buildingLength = buildingLength;
            this.buildingWeight = buildingWeight;
            this.buildingHeight = buildingHeight;
        }
        public void print()
        {
            Console.WriteLine("Здание по адресу {0}, имеет длину {1}, ширину {2}, высоту {3}", buildingAddress, buildingLength, buildingWeight, buildingHeight);
            return;
        }
    }
    sealed class MultiBuilding : Building
    {
        public int numberOfFloors { get; set; }
        public MultiBuilding(string buildingAddress, double buildingLength, double buildingWeight, double buildingHeight, int numberOfFloors)
            : base(buildingAddress, buildingLength, buildingWeight, buildingHeight)
        {
            this.numberOfFloors = numberOfFloors;
        }
        public new void print()
        {
            base.print();
            Console.WriteLine(", {0} эатажей", numberOfFloors);//немного криво с переносом строки но реализовано
        }
    }
}
