using API.Entities.Plans.Diet;
using API.Entities.Plans.Traning;
using Microsoft.AspNetCore.Identity;

namespace API.Entities
{
    public class AppUser : IdentityUser<int>
    {
        public ICollection<AppUserRole> UserRoles { get; set; }
        public virtual ICollection<DietPlan> DietPlans { get; set; }
        public virtual ICollection<Recipe> Recipes { get; set; }
        public virtual ICollection<TrainingPlan> TrainingPlans { get; set; }
        public virtual Motivator Motivator { get; set; }
    }
}
