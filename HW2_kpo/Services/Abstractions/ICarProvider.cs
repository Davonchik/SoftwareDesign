using kpo.HW2_kpo.Models;

namespace kpo.HW2_kpo.Services.Abstractions;

/// <summary>
/// Interface that provides cars to buyers.
/// </summary>
public interface ICarProvider
{
    Car? TakeCar(Customer customer);
}
