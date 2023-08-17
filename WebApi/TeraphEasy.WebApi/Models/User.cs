namespace TeraphEasy.WebApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string CompleteName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }

        public ICollection<Session> Sessions { get; set; }
        public ICollection<Message> Messages { get; set; }
    }
}
