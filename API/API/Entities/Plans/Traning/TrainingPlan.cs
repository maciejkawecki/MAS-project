using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.ConstrainedExecution;
using API.Entities.Plans.Diet;

namespace API.Entities.Plans.Traning
{
    public class TrainingPlan
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DegreeOfDifficulty { get; set; }
        public int TrainingLength { get; set; }
        public int NumberOfRepetitions { get; set; }
        public int NumberOfSeries { get; set; }
        public int NumberOfTrainingDaysPerWeek { get; set; }
        public bool Active { get; set; }
        public ICollection<ExerciseTraningPlan> ExerciseTraningPlans { get; set; }
        public AppUser AdminAndModerator { get; set; }
        public ICollection<AppUser> Users { get; set; }
    }
}
