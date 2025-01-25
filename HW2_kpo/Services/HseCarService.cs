using kpo.HW2_kpo.Models;
using kpo.HW2_kpo.Services.Abstractions;

namespace kpo.HW2_kpo.Services;

public class HseCarService
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
    public HseCarService(ICarProvider carProvider, ICustomersProvider customersProvider)
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

            var car = _carProvider.TakeCar(customer);

            if (car == null)
                continue;

            customer.Car = car;
        }
    }
    
}
