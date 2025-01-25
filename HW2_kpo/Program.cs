using kpo.HW2_kpo.Models;
using kpo.HW2_kpo.Services;

namespace kpo.HW2_kpo;

internal class Program
{
    static void Main(string[] args)
    {
        var carService = new CarService();
        var customerStorage = new CustomersStorage();
        var hseCarService = new HseCarService(carService, customerStorage);
        var pedalCarFactory = new PedalCarFactory();
        var handCarFactory = new HandCarFactory();

        customerStorage.AddCustomer(new Customer("Davo", 6, 4));
        customerStorage.AddCustomer(new Customer("Tigran", 4, 6));
        customerStorage.AddCustomer(new Customer("Edgar", 6, 6));
        customerStorage.AddCustomer(new Customer("Gev", 4, 4));

        carService.AddCar(pedalCarFactory, new PedalEngineParams(4));
        carService.AddCar(pedalCarFactory, new PedalEngineParams(4));
        carService.AddCar(handCarFactory, new EmptyEngineParams());
        carService.AddCar(handCarFactory, new EmptyEngineParams());

        Console.WriteLine("=== Покупатели (before) ===");
        foreach (var customer in customerStorage.GetCustomers())
            Console.WriteLine(customer);

        Console.WriteLine("\n=== Список автомобилей в наличии (before) ===");
        foreach (var car in carService.GetAllCars())
            Console.WriteLine(car);

        Console.WriteLine("\n=== Продажа автомобилей ===\n");
        hseCarService.SellCars();

        Console.WriteLine("=== Покупатели (after) ===");
        foreach (var customer in customerStorage.GetCustomers())
            Console.WriteLine(customer);

        Console.WriteLine("\n=== Список автомобилей в наличии (after) ===");
        foreach (var car in carService.GetAllCars())
            Console.WriteLine(car);
    }
}