namespace CarSystem {
    public class FactoryAF
    {
        public Queue<Car> Cars { get; private set; }
        public List<Customer> Customers { get; private set; }

        public FactoryAF(List<Customer> customers)
        {
            Customers = customers;
            Cars = new Queue<Car>();
        }

        internal void SaleCar()
        {
            foreach (var customer in Customers)
            {
                if (customer.Car == null)
                {
                    if (Cars.Count == 0)
                        break;

                    customer.Car = Cars.Dequeue();
                }
            }
            Customers = Customers.Where(customer => customer.Car != null).ToList();

            Cars.Clear();
        }

        internal void AddCar()
        {
            var car = new Car();
            Cars.Enqueue(car);
        }
    }
}
