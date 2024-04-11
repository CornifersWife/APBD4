namespace APBD4.Animals;

public class AnimalService : IAnimalService {
    private static List<Animal> animalList = new List<Animal>();

    public List<Animal> GetAnimals() {
        return animalList;
    }

    public Animal GetAnimal(int id) {
        return animalList.FirstOrDefault(animal => animal.Id == id);
    }

    public void RemoveAnimal(Animal animal) {
        animalList.Remove(animal);
    }

    public void AddAnimal(Animal animal) {
        animalList.Add(animal);
    }

    public void ChangeAnimalInfo(Animal oldAnimal, Animal newAnimal) {
        oldAnimal.Name = newAnimal.Name;
        oldAnimal.Category = newAnimal.Category;
        oldAnimal.Mass = newAnimal.Mass;
        oldAnimal.FurColor = newAnimal.FurColor;
    }
}