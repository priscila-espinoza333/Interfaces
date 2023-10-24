public class Bird : Animal, ILayEggs
{
    public bool CanFly;
    // Our EggsPerBatch from our interface
    public int EggsPerBatch {get;set;}
    public Bird(bool canfly, string diet, int epb) : base("Bird", diet, true)
    {
        CanFly = canfly;
        EggsPerBatch = epb;
    }
    // Filling out the LayEggs method from our interface
    public void LayEggs()
    {
        Console.WriteLine($"{Name} laid {EggsPerBatch} egg(s)!");
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Can Fly: {CanFly}");
    }

    public class Bird : Animal, ILayEggs
{
    // previous Bird code here...
    // Override is our keyword here, just like how we overwrote virtual parent methods
    public override void MakeNoise()
    {
    	Console.WriteLine("Tweet, tweet, tweet!");
    }
}


}

