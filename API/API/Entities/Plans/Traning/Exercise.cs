namespace API.Entities.Plans.Traning
{
    public abstract class Exercise
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<string> Photos { get; set; }
        public ICollection<string> Videos { get; set; }
        public string MuscleGroups { get; set; }
        public ICollection<ExerciseTraningPlan> ExerciseTraningPlans { get; set; }
    }
}
