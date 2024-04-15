using APBD4.Animals;

namespace APBD4.Visits;

public interface IVisitService {
    public List<Visit> GetAnimalVisits(int idAnimal);
    public void AddNewVisit(Visit newVisit);
}