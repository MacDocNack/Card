using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ScoreCard customer = new ScoreCard(59);
            ScoreCard customer1 = new ScoreCard(533);
            ScoreCard customer2 = new ScoreCard(32);
            ScoreCard customer3 = new ScoreCard(264);
            ScoreCard customer4 = new ScoreCard(159);
            ScoreCard customer5 = new ScoreCard(0);

            Console.ReadKey();
        }
    }

    class ScoreCard
    {
        public float Score { get; set; }
        public float Discount { get; set; }

        public ScoreCard(float score)
        {
            Score = score;
            CalculateDiscount();
            if (Discount >= 0)
                Console.WriteLine($"Customer discount = {Discount * 100}% \n");
        }

        public void CalculateDiscount()
        {
            if (Score >= 0 && Score < 100) Discount = 0.01f;
            else if (Score >= 100 && Score < 200) Discount = 0.03f;
            else if (Score >= 200 && Score < 500) Discount = 0.05f;
            else if (Score >= 500) Discount = 0.1f;
            else if (Score < 0)
            {
                Console.WriteLine("Score has been less then 0");
                Discount = -1;
                return;
            };
        }
    }
}
