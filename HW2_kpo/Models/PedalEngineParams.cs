using kpo.HW2_kpo.Models.Abstractions;

namespace kpo.HW2_kpo.Models;

/// <summary>
/// Pedal engine parameters.
/// </summary>
public record PedalEngineParams : EngineParamsBase
{
    public uint PedalSize { get; }

    public PedalEngineParams(uint pedalSize)
    {
        PedalSize = pedalSize;
    }
}