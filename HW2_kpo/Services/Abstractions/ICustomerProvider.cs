using kpo.HW2_kpo.Models;

namespace kpo.HW2_kpo.Services.Abstractions;

/// <summary>
/// Interface providing a list of buyers.
/// </summary>
public interface ICustomersProvider
{
    /// <summary>
    /// Brings shoppers back to the car queue.
    /// </summary>
    IEnumerable<Customer> GetCustomers();
}
