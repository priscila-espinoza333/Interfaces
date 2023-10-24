abstract class Animal
{
    // previous Animal code here...
    // Our abstract method must be either public or protected so it is accessible to its child classes
    public abstract void MakeNoise();
abstract class Animal
{
    public string Name;
    public string Diet;
    public bool IsMammal;
    public Animal(string name, string diet, bool ismammal)
    {
        Name = name;
        Diet = diet;
        IsMammal = ismammal;
    }
    public virtual void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Diet: {Diet}");
        Console.WriteLine($"Mammal: {IsMammal}");
    }
}



}

