using kpo.HW2_kpo.Models.Abstractions;

namespace kpo.HW2_kpo.Models;

/// <summary>
/// Car.
/// </summary>
public class Car
{
    public Guid Number { get; }
    public IEngine Engine { get; }

    public Car(IEngine engine, Guid number)
    {
        ArgumentNullException.ThrowIfNull(engine, nameof(engine));

        Engine = engine;
        Number = number;
    }

    public bool IsCompatible(Customer customer) 
    {
        return Engine.IsCompatible(customer);
    }

    public override string ToString()
    {
        return $"Номер: {Number}, Двигатель: {{ {Engine} }}";
    }
}
