Bird MyBird = new Bird(true, "Herbivore", 3);
Reptile MyReptile = new Reptile("Onmivorous", 6);
List<ILayEggs> canLayEggs = new List<ILayEggs>();
canLayEggs.Add(MyBird);
canLayEggs.Add(MyReptile);
foreach(ILayEggs e in canLayEggs)
{
    e.LayEggs();
}


