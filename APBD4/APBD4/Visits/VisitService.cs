using APBD4.Animals;

namespace APBD4.Visits;

public class VisitService : IVisitService {
    private static List<Visit> visits = new List<Visit>();
    
    public List<Visit> GetAnimalVisits(Animal animal) {
        return visits.Where(visit => visit.animal == animal).ToList();
    }

    public void AddNewVisit(Visit newVisit) {
        visits.Add(newVisit);
    }
}