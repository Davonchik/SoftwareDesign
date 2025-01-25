using kpo.HW2_kpo.Models;
using kpo.HW2_kpo.Services.Abstractions;

namespace kpo.HW2_kpo.Services;

/// <summary>
/// Fabrica for creating cars with pedal drive.
/// </summary>
public class PedalCarFactory : ICarFactory<PedalEngineParams>
{
    public Car CreateCar(PedalEngineParams carParams)
    {
        var engine = new PedalEngine(carParams.PedalSize);
        return new Car(engine, number: Guid.NewGuid());
    }
}
