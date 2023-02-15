// base Class 
class Animal
{
    private string name; // only accessible within this class
    protected string type; //accessible from derived classes
    public string color;  // accessible from any class

    public void setName(string name)
    {
        this.name = name;
    }
    public virtual string getName()
    {
        return this.name;
    }
    public void setType(string type)
    {
        this.type = type;
    }
    public virtual string getType()
    {
        return this.type;
    }
}
class Elephant : Animal
{
    private string name;
    private string _Trunk;
    private string _Ears;
    private string _Mirror;

    public Elephant()
        :base()
    {
        name = "";
        _Trunk = "";
        _Ears = "";
        _Mirror = "";
    }
    public new void setName(string name)
    {
        this.name=name;
    }
    public override string getType()
    {
        return type; 
    }
    public override string getName()
    {
        return name;
    }
    public string getTrunk()
    {
        return _Trunk;
    }
    public string getEars()
    {
        return _Ears;
    }
    public string getMirror()
    {
        return _Mirror; 
    }
    public void setTrunk(string trunk)
    {
        _Trunk = trunk;
    }
    public void setEars(string ears)
    {
        _Ears = ears;
    }
    public void setMirror(string mirror)
    {
        _Mirror = mirror;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();
        myAnimal.setName("Clifford");
        myAnimal.setType("Dog");
        myAnimal.color = "Red";
        Console.WriteLine($"My animal's name is {myAnimal.getName()} and he is a {myAnimal.getType()} and is the color {myAnimal.color}.");

        Elephant myElephant = new Elephant();
        myElephant.setName("Dumbo");
        myElephant.setType("elephant");
        myElephant.color = "gray";
        myElephant.setTrunk("trunk");
        myElephant.setEars("large ears");
        myElephant.setMirror("Fun fact: Elephants are one of very few species that can recognize themselves in a mirror.");
        Console.WriteLine($"My animals name is {myElephant.getName()}. {myElephant.getName()} is a {myElephant.color} {myElephant.getType()} that " +
            $"has a large {myElephant.getTrunk()} and {myElephant.getEars()}. {myElephant.getMirror()}.");
    }
}