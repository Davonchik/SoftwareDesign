using kpo.HW2_kpo.Models;
using kpo.HW2_kpo.Models.Abstractions;
using kpo.HW2_kpo.Services.Abstractions;

namespace kpo.HW2_kpo.Services;

public class CarStorage : ICarProvider
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
        var car = carFactory.CreateCar(carParams);
        _cars.AddLast(car);
    }

    public Car? GetCar(EngineType engineType)
    {
        var car = _cars.FirstOrDefault(car => car.Engine.Type == engineType);

        if (car != null)
            _cars.Remove(car);

        return car;
    }
}
