namespace kpo.HW2_kpo.Models.Abstractions;

/// <summary>
/// Basic structure for transmitting engine parameters.
/// </summary>
public abstract record EngineParamsBase
{
    /// <summary>
    /// Public static read-only field to avoid writing new every time.
    /// </summary>
    public static readonly EmptyEngineParams Empty = new();
}
