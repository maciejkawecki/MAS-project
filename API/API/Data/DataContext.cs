using API.Entities;
using API.Entities.Plans.Diet;
using API.Entities.Plans.Traning;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace API.Data
{
    public class DataContext : IdentityDbContext<AppUser, AppRole, int, IdentityUserClaim<int>, 
        AppUserRole, IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<DietPlan> DietPlans { get; set; }
        public DbSet<TrainingPlan> TrainingPlans { get; set; }
        public DbSet<ExerciseTraningPlan> ExerciseTraningPlans { get; set; }
        public DbSet<DishDietPlan> DishDietPlans { get; set; }
        public DbSet<Dish> Dishs { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Motivator> Motivators { get; set; }
        public DbSet<Instrument> Instruments { get; set; }
        public DbSet<ExerciseWithoutTheDevice> ExerciseWithoutTheDevices { get; set; }
        public DbSet<ExerciseWithTheDevice> ExerciseWithTheDevices { get; set; }
        public DbSet<CompositionOfNutritionalValue> CompositionOfNutritionalValues { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AppUser>()
                .HasMany(ur => ur.UserRoles)
                .WithOne(u => u.User)
                .HasForeignKey(ur => ur.UserId)
                .IsRequired();

            builder.Entity<AppRole>()
                .HasMany(ur => ur.UserRoles)
                .WithOne(u => u.Role)
                .HasForeignKey(ur => ur.RoleId)
                .IsRequired();

            //builder.Entity<DietPlan>()
            //    .HasMany(d => d.DishDietPlans)
            //    .WithOne(c => c.DietPlan)
            //    .HasForeignKey(c => c.Id)
            //    .IsRequired();

            // builder.ApplyUtcDateTimeConverter();
        }
    }
}
