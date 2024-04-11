namespace APBD4.Animals;

public class Animal
{
    public int Id { get; private set; }
    public string Name { get; set; }
    public Category Category { get; set; }
    public float Mass { get; set; }
    public string FurColor { get; set; }

    private static int newId = 0;
    public Animal(string name, Category category, float mass, string furColor)
    {
        Id = newId++;
        Name = name;
        Category = category;
        Mass = mass;
        FurColor = furColor;
    }
}