
using APBD4.Animals;

namespace APBD4;

public static class Configuration
{
    public static void RegisterEndpointsForAnimals(this IEndpointRouteBuilder app) {
        app.MapGet("/api/v1/animals", () => {
            //logika
            return TypedResults.Ok();
        });
        app.MapGet("/api/v1/animals/{id::int}", (int id) => {
            //logika
            return TypedResults.Ok();
        });
        app.MapDelete("/api/v1/animals", (int id) => {
            return TypedResults.Ok();
        });
        app.MapPut("/api/v1/animals", (Animal newAnimal) =>
        {
            //
            return TypedResults.Ok();
        });
        app.MapPost("/api/v1/animals", (Animal newAnimal) =>
        {
            //
            return TypedResults.Ok();
        });
    }
}