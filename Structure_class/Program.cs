using System;

namespace App
{
    public struct Disk
    {
        public string Brand;
        public int Capacity;

        public Disk(string brand, int capacity)
        {
            Brand = brand;
            Capacity = capacity;
        }

        public override string ToString() => $"Disque de {Brand}, avec une capacité de {Capacity}Go";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Disk d = new Disk("Toshiba", 1000);
            Console.WriteLine(d);

            Stock stock_disks = new Stock(100);
            Stock stock_mouses = new Stock(50);
            Console.WriteLine(stock_disks);

        }
    }
}

