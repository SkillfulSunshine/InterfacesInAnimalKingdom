namespace InterfacesInAnimalKingdom.Animals;

public class Animal
{
    public string Name { get; set; } = default!;
    public string Origin { get; set; } = default!;
    public int Age { get; set; } = default!;

    public virtual void Speak()
    {
        Console.WriteLine($"{Name} makes a sound. Sounds like {Origin}!");
    }

    public virtual string Describe() => $"{Name} is a general animal from {Origin}. Age: {Age}";
}
