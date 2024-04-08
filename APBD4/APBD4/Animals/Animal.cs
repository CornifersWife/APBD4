namespace APBD4.Animals;

public class Animal : IAnimalService
{
    private static int newId = 0;
    int id;
    string name;
    Category category;
    float mass;
    string furColor;
    public static List<Animal> animalList = new List<Animal>();

    public Animal(string name, Category category, float mass, string furColor)
    {
        id = newId;
        newId++;
        this.name = name;
        this.category = category;
        this.mass = mass;
        this.furColor = furColor;
        animalList.Add(this);
    }

    public List<Animal> GetAnimals()
    {
        return animalList;
    }

    public Animal GetAnimal(int animalId)
    {
        return animalList.Find( animal => animalId == animal.id);
    }

    public void RemoveAnimal(Animal animal)
    {
        throw new NotImplementedException();
    }

    public void AddAnimal(Animal animalToBeAdded)
    {
        throw new NotImplementedException();
    }

    public void changeAnimalInfo(Animal newAnimal)
    {
        throw new NotImplementedException();
    }
}