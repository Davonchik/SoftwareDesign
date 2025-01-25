using kpo.HW2_kpo.Models.Abstractions;

namespace kpo.HW2_kpo.Models;

/// <summary>
/// Engine with hand drive.
/// </summary>
public class HandEngine : IEngine
{
    public HandEngine() { }

    public bool IsCompatible(Customer customer)
    {
        return customer.HandStrength > 5;
    }

    public override string ToString()
    {
        return "Тип: ручной привод";
    }
}