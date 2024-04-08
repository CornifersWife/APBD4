using APBD4.Animals;

namespace APBD4;

public class Visit
{
    Animal animal;
    DateTime dateTime;
    string? description;
    float price;


    public Visit(Animal animal, DateTime dateTime, string? description, float price)
    {
        this.animal = animal;
        this.dateTime = dateTime;
        this.description = description;
        this.price = price;
    }
}