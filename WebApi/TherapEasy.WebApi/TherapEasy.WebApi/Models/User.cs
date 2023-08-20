using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Design;

namespace TherapEasy.WebApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsTherapist { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }

        public ICollection<Session> SessionsAsTherapist { get; set; }
        public ICollection<Session> SessionsAsPatient { get; set; }
    }
}
