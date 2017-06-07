using System;
using System.Threading.Tasks;
using DesignPatterns.AbstractFactory;
using DesignPatterns.Factory;
using static System.Console;
namespace DesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            var i = ExecutePatterns();

            Console.WriteLine($"Operations Completed : {i.Result}");
        }

        private async static Task<bool> ExecutePatterns()
        {
            //var factoryTask = Task.Run(() => ExecuteFactoryAsync());
            //var abstractFactoryTask = Task.Run(() => ExecuteAbstractFactoryAsync());

            var factoryTask = ExecuteFactoryAsync();
            var abstractFactoryTask = ExecuteAbstractFactoryAsync();

            await factoryTask;
            await abstractFactoryTask;

            return true;
        }

        private static async Task ExecuteFactoryAsync()
        {
            WriteLine("Inside Factory Method");
            var creator = new Creator(new AutoFactory());

            var vehicle = creator.Create();

            Console.WriteLine($"{{VehicleName:}} {vehicle.Name}");

            creator = new Creator(new CycleFactory());
            
            vehicle = creator.Create();

            Console.WriteLine($"{{VehicleName:}} {vehicle.Name}");

            WriteLine("Factory Method Tested Successfully");
        }

        private static async Task ExecuteAbstractFactoryAsync()
        {
            WriteLine("Inside Abstract Factory Method");
            
            var bmwWorld = new AutoWorld(new BmwFactory());

            Console.WriteLine($"{{Car:}} {bmwWorld.Auto.Name}");
            Console.WriteLine($"{{Cycle:}} {bmwWorld.Cycle.Name}");

            var hondaWorld = new AutoWorld(new HondaFactory());

            Console.WriteLine($"{{Car:}} {hondaWorld.Auto.Name}");
            Console.WriteLine($"{{Cycle:}} {hondaWorld.Cycle.Name}");

            WriteLine("Abstract Factory Method Tested Successfully");
        }
    }
}
