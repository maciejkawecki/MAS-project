namespace API.Entities.Plans.Diet
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IngredientsNeeded { get; set; }
        public string StepsToCreate { get; set; }
        public ICollection<string> Photos { get; set; }
        public bool Active { get; set; }
        public AppUser User { get; set; }
    }
}
