using APBD4.Animals;

namespace APBD4.Visits;

public class Visit
{
    public Animal animal;
    public DateTime dateTime;
    public string? description;
    public float price;


    public Visit(Animal animal, DateTime dateTime, string? description, float price)
    {
        this.animal = animal;
        this.dateTime = dateTime;
        this.description = description;
        this.price = price;
    }
}