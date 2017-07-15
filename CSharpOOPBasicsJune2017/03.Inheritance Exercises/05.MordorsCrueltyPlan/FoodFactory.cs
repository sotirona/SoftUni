using _05.MordorsCrueltyPlan.FoodModels;


namespace _05.MordorsCrueltyPlan
{
    public class FoodFactory
    {
        public Food CreateFood(string food)
        {
            switch (food)
            {
                case "cram":
                    return new Cram();
                case "lembas":
                    return new Lembas();
                case "apple":
                    return new Apple();
                case "melon":
                    return new Melon();
                case "honeycake":
                    return new HoneyCake();
                case "mushrooms":
                    return new Mushrooms();
                default:
                    return new OtherFood();
            }
        }
    }
}
