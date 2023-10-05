namespace InterfacesInAnimalKingdom.Animals;

public class Mammal : Animal
{
    public bool HasFur { get; set; } = true;
    public bool IsDomestic { get; set; } = false;

    public virtual void FeedMilk()
    {
        Console.WriteLine($"{Name} feeds its young with milk.");
    }

    public override string Describe() => $"{Name} is a {(IsDomestic ? "domestic" : "wild")} mammal from {Origin}.";
}
