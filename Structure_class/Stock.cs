 public class Stock
    {
        private int Capacity;
        public Stock()
        {
            Capacity = 100;
        }
        public Stock(int capacity)
        {
            Capacity = capacity;
        }

        public override string ToString() => $"Disque d'une capacité de {Capacity}Go";
    }