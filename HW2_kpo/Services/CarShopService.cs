using kpo.HW2_kpo.Models;
using kpo.HW2_kpo.Services.Abstractions;

namespace kpo.HW2_kpo.Services;

public class CarShopService
{
    /// <summary>
    /// Service that provides cars.
    /// </summary>
    private readonly ICarProvider _carProvider;

    /// <summary>
    /// Service that provides customers.
    /// </summary>
    private readonly ICustomersProvider _customersProvider;

    /// <summary>
    /// Class constructor.
    /// </summary>
    public CarShopService(ICarProvider carProvider, ICustomersProvider customersProvider)
    {
        ArgumentNullException.ThrowIfNull(carProvider, nameof(carProvider));
        ArgumentNullException.ThrowIfNull(customersProvider, nameof(customersProvider));

        _carProvider = carProvider;
        _customersProvider = customersProvider;
    }

    public void SellCars()
    {
        var customers = _customersProvider.GetCustomers();

        foreach (var customer in customers)
        {
            if (customer.Car != null)
                continue;

            var suitableEngineType = DetermineEngineType(customer);

            if (!suitableEngineType.HasValue)
                continue;

            var car = _carProvider.GetCar(suitableEngineType.Value);

            if (car == null)
                continue;

            customer.Car = car; // иначе вручаем автомобиль
        }
    }

    /// <summary>
    /// Determining the type of engine that would suit the user based on physical parameters.
    /// </summary>
    /// <param name="customer">Customer.</param>
    /// <returns>Returns required engine type.</returns>
    private static EngineType? DetermineEngineType(Customer customer)
    {
        if (customer.LegStrength > 5)
            return EngineType.Pedal;

        if (customer.HandStrength > 5)
            return EngineType.Hand;

        return null;
    }
}
