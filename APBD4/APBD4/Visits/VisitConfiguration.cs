using APBD4.Animals;

namespace APBD4.Visits;

public static class VisitConfiguration {
    public static void RegisterEndpointsForVisits(this IEndpointRouteBuilder app) {
        app.MapGet("/api/v1/visits/{idAnimal:int}", (int idAnimal, IVisitService service) => {
                return TypedResults.Ok(service.GetAnimalVisits(idAnimal));
            });
        
        app.MapPut("/api/v1/visits", (Visit newVisit, IVisitService service) => {
            service.AddNewVisit(newVisit);
            return TypedResults.Ok();
        });
    }
}