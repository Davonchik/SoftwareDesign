using kpo.HW2_kpo.Models.Abstractions;

namespace kpo.HW2_kpo.Models;

/// <summary>
/// Engine with pedal drive.
/// </summary>
public class PedalEngine : IEngine
{
    public uint Size { get; }

    public PedalEngine(uint size)
    {
        Size = size;
    }

    public bool IsCompatible(Customer customer)
    {
        return customer.LegStrength > 5;
    }

    public override string ToString()
    {
        return "Тип: педальный привод";
    }
}