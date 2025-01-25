using kpo.HW2_kpo.Models;
using kpo.HW2_kpo.Models.Abstractions;
using kpo.HW2_kpo.Services.Abstractions;

namespace kpo.HW2_kpo.Services;

public class CarService : ICarProvider
{
    /// <summary>
    /// Collection for cars saving.
    /// </summary>
    private readonly LinkedList<Car> _cars = new();

    /// <summary>
    /// Method for adding a car to the collection.
    /// </summary>
    public void AddCar<TParams>(ICarFactory<TParams> carFactory, TParams carParams)
        where TParams : EngineParamsBase
    {
        var car = carFactory.CreateCar(carParams, Guid.NewGuid());
        _cars.AddLast(car);
    }

    public Car? TakeCar(Customer customer)
    {
        var car = _cars.FirstOrDefault(x => x.IsCompatible(customer));

        if (car is not null)
        {
            _cars.Remove(car);
        }
        
        return car;
    }

    public IEnumerable<Car> GetAllCars()
    {
        return _cars.ToList();
    }
}
