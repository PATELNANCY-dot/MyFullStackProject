using System.ComponentModel.DataAnnotations;

namespace MyFullStackProject.Models
{
    public class Otp
    {
        [Key]
        public int Id { get; set; }

        public string Email { get; set; }

        public string Code { get; set; }

        public DateTime ExpiryTime { get; set; }

        public bool IsUsed { get; set; }
    }
}
