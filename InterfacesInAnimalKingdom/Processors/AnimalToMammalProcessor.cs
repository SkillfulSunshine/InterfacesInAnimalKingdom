namespace InterfacesInAnimalKingdom.Processors;

public class AnimalToMammalProcessor : IProcessor<Animal, Mammal>
{
    public Mammal Process(Animal input)
    {
        return new Mammal
        {
            Name = input.Name,
            Age = input.Age,
            IsDomestic = false
        };
    }
}
