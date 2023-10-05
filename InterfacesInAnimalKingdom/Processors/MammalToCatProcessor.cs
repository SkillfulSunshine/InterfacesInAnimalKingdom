namespace InterfacesInAnimalKingdom.Processors;

public class MammalToCatProcessor : IProcessor<Mammal, Cat>
{
    public Cat Process(Mammal input)
    {
        return new Cat
        {
            Name = input.Name,
            Age = input.Age,
            IsDomestic = input.IsDomestic,
            Color = "Black"
        };
    }
}

