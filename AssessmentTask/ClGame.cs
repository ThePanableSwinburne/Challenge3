using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentTask
{
    public class ClGame : Game
    {
        public string Name { get; set; }
        public List<int> Results { get; set; } = new List<int>();

        public double GetAverage()
        {
            if (Results.Count == 0) return 0;
            return (double)GetTotal() / (double)Results.Count();
        }

        public int GetTotal()
        {
            int total = 0;
            foreach (var item in Results)
            {
                total += item;
            }
            return total;
        }

        public override int RollAllDice()
        {
            foreach (var dice in Die)
            {
                var result = dice.Roll();
                Results.Add(result);
            }

            return 1;
        }
    }
}
