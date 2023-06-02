using API.Entities.Plans.Traning;

namespace API.Entities.Plans.Diet
{
    public class DishDietPlan
    {
        public ICollection<Dish> Dishes { get; set; } = null!;
        public DietPlan DietPlan { get; set; } = null!;
    }
}
