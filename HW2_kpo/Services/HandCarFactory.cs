﻿using kpo.HW2_kpo.Models;
using kpo.HW2_kpo.Services.Abstractions;

namespace kpo.HW2_kpo.Services;

/// <summary>
/// Fabrica for creating cars with hand drive.
/// </summary>
public class HandCarFactory : ICarFactory<EmptyEngineParams>
{
    public Car CreateCar(EmptyEngineParams engineParams, Guid numberOfCar)
    {
        var engine = new HandEngine();
        return new Car(engine, numberOfCar);
    }
}
