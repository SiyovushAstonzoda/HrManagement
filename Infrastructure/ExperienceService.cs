namespace Infrastructure;
using Domain.Models;

public class ExperienceService
{
    private List<Experience> experiences;

    public ExperienceService()
     {
         experiences = new List<Experience>();
     }

    List<Experience> GetExperiences()
    {
        return experiences;
    }

     public void Add(Experience experience)
    {
        experiences.Add(experience);
    }

    public void Update(Experience experience, int id)
    {
        var find = experiences.Find(x=>x.Id == id);
        find.Name = experience.Name;
        find.Description = experience.Description;
        find.Company = experience.Company;
        find.EmployeeId = experience.EmployeeId;
    }

    public Experience GetExperienceById(int id)
    {
        var experience =  experiences.Find(element=> element.Id == id);
        return experience;
    }

    public void Delete(int id)
    {
         var find = experiences.Find(x=>x.Id == id);
         experiences.Remove(find);
    }

    private int Count()
    {
        return experiences.Count;
    }
}
