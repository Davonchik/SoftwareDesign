using kpo.HW2_kpo.Models;
using kpo.HW2_kpo.Models.Abstractions;

namespace kpo.HW2_kpo.Services.Abstractions;

/// <summary>
/// Main interface for creating cars.
/// </summary>
public interface ICarFactory<TParams> where TParams : EngineParamsBase
{
    /// <summary>
    /// Car creation method.
    /// </summary>
    Car CreateCar(TParams engineParams, Guid numberOfCar);
}
