using CoinJar.Interfaces;

namespace CoinJar.Classes
{
    public class Coin : ICoin
    {
        public decimal Amount { get; set; }
        public decimal Volume { get; set; }

        public Coin(decimal Amount, decimal Volume)
        {
            this.Amount = Amount;
            this.Volume = Volume;
        }
    }
}
