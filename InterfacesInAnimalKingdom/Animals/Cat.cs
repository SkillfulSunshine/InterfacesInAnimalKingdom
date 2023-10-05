namespace InterfacesInAnimalKingdom.Animals;

public class Cat : Mammal
{
    public string Color { get; set; } = default!;

    public override void Speak()
    {
        Console.WriteLine($"{Name}, the {Color} cat, meows.");
    }

    public void Purr()
    {
        Console.WriteLine($"{Name} purrs.");
    }

    public override string Describe() => $"{Name} is a {Color} {(IsDomestic ? "domestic" : "wild")} cat from {Origin}.";
}
