namespace APBD4.Animals;

public static class AnimalConfiguration
{
    public static void RegisterEndpointsForAnimals(this IEndpointRouteBuilder app) {
 
        app.MapGet("/api/v1/animals", (IAnimalService service) => {
            return TypedResults.Ok(service.GetAnimals());
        });
        
        app.MapGet("/api/v1/animals/{id::int}", (int id,IAnimalService service) => {
            return TypedResults.Ok(service.GetAnimal(id));
        });
 
        
        app.MapPut("/api/v1/animals", (Animal newAnimal, IAnimalService service) => {
            service.AddAnimal(newAnimal);
            return Results.Ok("Animal added");
        });

        app.MapDelete("/api/v1/animals", (int id,IAnimalService service) => {
            Animal animalToRemove = service.GetAnimal(id);
            service.RemoveAnimal(animalToRemove);
            return TypedResults.Ok("Animal removed");
        });
        app.MapPost("/api/v1/animals/{id::int}", (int id, Animal newAnimal,IAnimalService service) => {
            Animal oldAnimal = service.GetAnimal(id);
            service.ChangeAnimalInfo(oldAnimal,newAnimal);
            return TypedResults.Ok("Animal info changed");
        });
    }
}