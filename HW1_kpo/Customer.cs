namespace CarSystem {
    /// <summary>
    /// Customer class.
    /// </summary>
    public class Customer
    {
        public required string Name { get; set; }

        public Car? Car { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Car number: {Car?.Number ?? -1}";
        }
    }
}