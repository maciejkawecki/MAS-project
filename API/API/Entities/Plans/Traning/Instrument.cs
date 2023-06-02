namespace API.Entities.Plans.Traning
{
    public class Instrument
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ExerciseWithTheDevice> ExerciseWithTheDevices { get; set; }
    }
}
