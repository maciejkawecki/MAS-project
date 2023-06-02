namespace API.Entities.Plans.Traning
{
    public class ExerciseWithTheDevice : Exercise
    {
        public ICollection<Instrument> Instruments { get; set; }
    }
}
