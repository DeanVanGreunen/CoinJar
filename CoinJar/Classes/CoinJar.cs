using CoinJar.Interfaces;
using LiteDB;

namespace CoinJar.Classes
{
    public class CoinJar : ICoinJar
    {
        public void AddCoin(ICoin coin)
        {
            using (var db = new LiteDatabase(@"CoinJar.db"))
            {
                var col = db.GetCollection<Coin>("coins");
                var insert_coin = new Coin(coin.Amount,coin.Volume);
                col.Insert(insert_coin);
            }
        }

        public decimal GetTotalAmount()
        {
            decimal total = 0;
            using (var db = new LiteDatabase(@"CoinJar.db"))
            {
                var cols = db.GetCollection<Coin>("coins").FindAll().ToList();
                foreach(var coin in cols)
                {
                    total += coin.Amount;
                }
            }
            return total;
        }

        public void Reset()
        {
            using (var db = new LiteDatabase(@"CoinJar.db"))
            {
                var cols = db.GetCollection<Coin>("coins");
                cols.DeleteAll();
            }
        }
    }
}
