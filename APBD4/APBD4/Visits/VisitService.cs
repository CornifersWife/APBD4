using APBD4.Animals;

namespace APBD4.Visits;

public class VisitService : IVisitService {
    private static List<Visit> visits = new List<Visit>();
    
    public List<Visit> GetAnimalVisits(int idAnimal) {
        return visits.Where(visit => visit.animalId == idAnimal).ToList();
    }

    public void AddNewVisit(Visit newVisit) {
        visits.Add(newVisit);
    }
}