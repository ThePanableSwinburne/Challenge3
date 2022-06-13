using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentTask
{
    public abstract class Game
    {

        public List<Die> Die { get; set; } = new List<Die>();

        public abstract int RollAllDice();

        public void AddDie(int sides)
        {
            Die.Add(new Die(sides));
        }

    }
}
