namespace InterfacesInAnimalKingdom.Animals;

public class Dog : Mammal
{
    public string Breed { get; set; } = default!;

    public override void Speak()
    {
        Console.WriteLine($"{Name}, the {Breed} dog, barks.");
    }

    public void Fetch()
    {
        Console.WriteLine($"{Name} fetches the ball.");
    }

    public override string Describe() => $"{Name} is a {Breed} breed {(IsDomestic ? "domestic" : "wild")} dog from {Origin}.";
}
