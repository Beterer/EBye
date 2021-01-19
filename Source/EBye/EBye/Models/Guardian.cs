namespace EBye.Models
{
    public class Guardian
    {
        public int GuardianId { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public bool ConfirmedDeath { get; set; }
    }
}
