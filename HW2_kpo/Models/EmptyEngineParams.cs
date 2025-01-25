using kpo.HW2_kpo.Models.Abstractions;

namespace kpo.HW2_kpo.Models;

/// <summary>
/// Struct if there is no params for engine.
/// </summary>
public record EmptyEngineParams : EngineParamsBase
{
    public static readonly EmptyEngineParams DEFAULT = new();
}
