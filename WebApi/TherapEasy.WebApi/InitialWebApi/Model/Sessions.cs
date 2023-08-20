using System.ComponentModel.DataAnnotations;

namespace InitialWebApi.Model
{
    public class Sessions
    {
        [Key]
        public int Id { get; set; }
        public int TherapistId { get; private set; }
        public int PatientId { get; private set; }
        public DateTime StartTime { get; private set; }
        public string? Description { get; private set; }

        public Sessions(int therapistId, int patientId, DateTime startTime, string description)
        {
            TherapistId = therapistId;
            PatientId = patientId;
            StartTime = startTime;
            Description = description;
        }

    }
}
