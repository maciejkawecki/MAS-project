using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class AccountDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Country { get; set; }
    }
}
