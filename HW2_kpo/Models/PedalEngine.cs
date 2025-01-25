using kpo.HW2_kpo.Models.Abstractions;

namespace kpo.HW2_kpo.Models;

/// <summary>
/// Engine with pedal drive.
/// </summary>
public class PedalEngine : IEngine
{
    public uint Size { get; }

    public EngineType Type => EngineType.Pedal;

    public PedalEngine(uint size)
    {
        Size = size;
    }

    public override string ToString()
    {
        return $"Тип: {Type}, Размер педалей: {Size}";
    }
}