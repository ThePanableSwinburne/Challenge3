using System;

namespace AssessmentTask
{
    public class Die
    {

        public int Sides { get; set; }

        public Die()
        {
            Sides = 6;
        }

        public Die(int num)
        {
            Sides = num;
        }

        public int Roll()
        {
            Random random = new Random();
            return random.Next(1, Sides + 1);
        }
    }
}
