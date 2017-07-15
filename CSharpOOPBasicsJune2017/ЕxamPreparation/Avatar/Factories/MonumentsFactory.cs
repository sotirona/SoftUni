
public class MonumentsFactory
{
    public static Monument GetMonument(string type, string name, int affinity)
    {
        switch (type)
        {
           case"Air":
                return new AirMonument(name, affinity);
            case"Fire":
                return new FireMonument(name, affinity);
                case"Earth":
                    return new EarthMonument(name, affinity);
            case "Water":
                return new WaterMonument(name, affinity);
            default:
                return null;

        }
    }
}



