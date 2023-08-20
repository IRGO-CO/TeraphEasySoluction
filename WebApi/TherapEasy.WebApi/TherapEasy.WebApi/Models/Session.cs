using System;
using Microsoft.EntityFrameworkCore.Design;

namespace TherapEasy.WebApi.Models
{
    public class Session
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }


        public int TherapistId { get; set; }
        public User Therapist { get; set; }
        
        public int PatientId { get; set; }
        public User Patient { get; set; }
    }
}
