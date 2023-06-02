namespace API.Entities
{
    public class Motivator
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Pseudonym { get; set; }
        public ICollection<string> MotivatingWords { get; set; }
        public ICollection<AppUser>  Users { get; set; }
    }
}
