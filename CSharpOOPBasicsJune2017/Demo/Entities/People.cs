
public abstract class People
{
    private string id;

    public string Id
    {
        get { return this.id; }
        private set { this.id = value; }
    }

    protected People(string id)
    {
        this.Id = id;
    }

}

