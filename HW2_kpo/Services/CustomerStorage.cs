using kpo.HW2_kpo.Models;
using kpo.HW2_kpo.Services.Abstractions;

namespace kpo.HW2_kpo.Services;

/// <summary>
/// Customers storage.
/// </summary>
public class CustomersStorage : ICustomersProvider
{
    public List<Customer> Customers { get; }

    public CustomersStorage()
    {
        Customers = [];
    }

    public void AddCustomer(Customer customer)
    {
        ArgumentNullException.ThrowIfNull(customer, nameof(customer));

        Customers.Add(customer);
    }

    public IEnumerable<Customer> GetCustomers()
    {
        return Customers.Where(customer => customer.Car == null);
    }
}