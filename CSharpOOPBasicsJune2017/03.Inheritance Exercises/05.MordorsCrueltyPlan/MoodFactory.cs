using _05.MordorsCrueltyPlan.MoodModels;

namespace _05.MordorsCrueltyPlan
{
    public class MoodFactory
    {
        public Mood GetMood(int points)
        {
            if (points < -5)
            {
                return new Angry();
            }
            if (points >= -5 && points <= 0)
            {
                return new Sad();
            }
            if (points <= 15)
            {
                return new Happy();
            }
            return new JavaScript();
        }
    }
}
