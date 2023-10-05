namespace InterfacesInAnimalKingdom.Interfaces;

public interface IProcessor<in TInput, out TOutput>
{
    TOutput Process(TInput input);
}