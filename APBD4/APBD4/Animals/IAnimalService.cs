namespace APBD4.Animals;

public interface IAnimalService
{
    public List<Animal> GetAnimals();
    public Animal GetAnimal(int animalId);
    public void RemoveAnimal(Animal animal);
    public void AddAnimal(Animal animalToBeAdded);
    public void changeAnimalInfo(Animal newAnimal);
}