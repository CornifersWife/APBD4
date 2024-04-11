using APBD4.Animals;

namespace APBD4.Visits;

public static class Configuration {
    public static void RegisterEndpointsForVisits(this IEndpointRouteBuilder app) {
        app.MapGet("/api/v1/visits", (Animal animal, IVisitService service) => {
                return TypedResults.Ok(service.GetAnimalVisits(animal));
            });
        app.MapPut("/api/v1/visits", (Visit newVisit, IVisitService service) => {
            service.AddNewVisit(newVisit);
            return TypedResults.Ok();
        });
    }
}