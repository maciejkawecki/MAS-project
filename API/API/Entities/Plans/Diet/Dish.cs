namespace API.Entities.Plans.Diet
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int AmountOfCaloriesInTheDish { get; set; }
        public ICollection<DishDietPlan> DishDietPlans { get; set; }
        public CompositionOfNutritionalValue CompositionOfNutritionalValue { get; set; }
    }
}
