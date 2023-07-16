namespace Domain.Interfaces.Factories;

public interface IAbstractFactory<T>
{
    T Create();
}
