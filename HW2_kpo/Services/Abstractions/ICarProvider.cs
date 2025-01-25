using kpo.HW2_kpo.Models;

namespace kpo.HW2_kpo.Services.Abstractions;

/// <summary>
/// Interface that provides cars to buyers.
/// </summary>
public interface ICarProvider
{
    /// <summary>
    /// Receiving a car with the appropriate engine type.
    /// </summary>
    /// <param name="engineType">Engine type.</param>
    /// <returns>Returns a suitable car, and if there are no such cars left - null.</returns>
    Car? GetCar(EngineType engineType);
}
