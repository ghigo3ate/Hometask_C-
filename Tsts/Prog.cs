using System;
namespace Tsts
{
    public class Prog
    {
        private double smth;
        public Prog(double price)
        {
            this.smth = price;
        }
        
        public double GetPrice()
        {
            return smth;
        }
        public void IncreasePrice(double count)
            => smth *= count;

        public void AddPrice(double count)
            => smth += count;
        
        public void SharePrice(double count)
            => smth /= count;

        public void SubtractNumFromPrice(double count)
            => smth -= count;
    }
}