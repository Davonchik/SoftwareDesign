namespace kpo.HW2_kpo.Models.Abstractions;

public interface IEngine
{
    public bool IsCompatible(Customer streingth);

    public string ToString();
}
