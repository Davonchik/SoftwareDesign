using kpo.HW2_kpo.Models.Abstractions;

namespace kpo.HW2_kpo.Models;

/// <summary>
/// Engine with hand drive.
/// </summary>
public class HandEngine : IEngine
{
    public EngineType Type => EngineType.Hand;

    public override string ToString()
    {
        return $"Тип: {Type}";
    }
}