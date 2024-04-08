
using APBD4.Animals;

namespace APBD4;

public static class Configuration
{
    public static void RegisterEndpointsForAnimals(this IEndpointRouteBuilder app) {
        
        app.MapGet("/api/v1/animals/{id::int}", (int id) => {
            //logika
            return TypedResults.Ok();
        });
        app.MapPost("/api/v1/animals", (Animal newAnimal) =>
        {
            //
            return TypedResults.Ok();
        });
        app.MapPost("/api/v1/animals", (Animal newAnimal) =>
        {
            //
            return TypedResults.Ok();
        });
        app.MapPost("/api/v1/animals", (Animal animalToRemove) =>
        {
            //
            return TypedResults.Ok();
        });
    }
}