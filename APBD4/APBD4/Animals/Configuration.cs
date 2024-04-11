using APBD4.Visits;
namespace APBD4.Animals;

public static class Configuration
{
    public static void RegisterEndpointsForAnimals(this IEndpointRouteBuilder app) {
        app.MapGet("/api/v1/animals", (IAnimalService service) => {
            return TypedResults.Ok(service.GetAnimals());
        });
        
        app.MapGet("/api/v1/animals/{id::int}", (int id,IAnimalService service) => {
            return TypedResults.Ok(service.GetAnimal(id));
        });
        
        app.MapPut("/api/v1/animals", (Animal newAnimal,IAnimalService service) => {
            service.AddAnimal(newAnimal);
            return TypedResults.Ok("Animal added");
        });
        app.MapDelete("/api/v1/animals", (int id,IAnimalService service) => {
            Animal animalToRemove = service.GetAnimal(id);
            service.RemoveAnimal(animalToRemove);
            return TypedResults.Ok("Animal removed");
        });
        app.MapPost("/api/v1/animals", (Animal newAnimal,IAnimalService service) => {
            Animal oldAnimal = service.GetAnimal(newAnimal.Id);
            service.ChangeAnimalInfo(oldAnimal,newAnimal);
            return TypedResults.Ok("Animal info changed");
        });
        
        
        app.MapGet("/api/v1/animals/visits", (Animal animal,IVisitService service) =>
        {
            return TypedResults.Ok(service.GetAnimalVisits(animal));
        });
        app.MapPut("/api/v1/animals/visits", (Visit newVisit,IVisitService service) =>
        {
            service.AddNewVisit(newVisit);
            return TypedResults.Ok();
        });
    }
}