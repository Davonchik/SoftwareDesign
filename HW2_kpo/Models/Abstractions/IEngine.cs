namespace kpo.HW2_kpo.Models.Abstractions;

/// <summary>
/// Engine description interface
/// </summary>
public interface IEngine
{
    /// <summary>
    /// Engine type
    /// </summary>
    EngineType Type { get; }

    public string ToString();
}
