namespace API.Entities.Plans.Traning
{
    public class ExerciseTraningPlan
    {
        public ICollection<Exercise> Exercises { get; set; }
        public TrainingPlan TrainingPlan { get; set; }
    }
}
