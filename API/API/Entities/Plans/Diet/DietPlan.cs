namespace API.Entities.Plans.Diet
{
    public class DietPlan
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int PlanCalories { get; set; }
        public bool Active { get; set; }
        public ICollection<DishDietPlan> DishDietPlans { get; set; }
        public AppUser AdminsAndModerator { get; set; }
        public AppUser User { get; set; }
    }
}
