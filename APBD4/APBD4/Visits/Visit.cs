using APBD4.Animals;

namespace APBD4.Visits;

public class Visit
{
    public int animalId { get; set; }
    public DateTime dateTime { get; set; }
    public string? description { get; set; }
    public float price { get; set; }


    public Visit(int animalId, DateTime dateTime, string? description, float price)
    {
        this.animalId = animalId;
        this.dateTime = dateTime;
        this.description = description;
        this.price = price;
    }
}