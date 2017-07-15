
public class BendersFactory
{
    public static Bender GetBender(string type, string name, int power, double secondaryParameter)
    {
        switch (type)
        {
            case "Air":
                return new AirBender(name, power, secondaryParameter);
            case "Fire":
                return new FireBender(name, power, secondaryParameter);
            case "Earth":
                return new EarthBender(name, power, secondaryParameter);
            case "Water":
                return new WaterBender(name, power, secondaryParameter); 
            default:
                return null;

        }
    }
}

