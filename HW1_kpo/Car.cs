namespace CarSystem {
    /// <summary>
    /// Car class.
    /// </summary>
    public class Car
    {
        private static readonly Random _random = new();
        private static int _globalCounter = 0;

        public int Number { get; }
        public Engine Engine { get; }

        public Car()
        {
            // При создании каждого нового Car увеличиваем счётчик.
            Number = System.Threading.Interlocked.Increment(ref _globalCounter);

            Engine = new Engine { Size = _random.Next(1, 10) };
        }

        public override string ToString()
        {
            return $"Number: {Number}, Pedal size: {Engine.Size}";
        }
    }
}