using backend.Core.Enums;
using backend.Core.Entities;

namespace backend.Core.Dtos.Athlete
{
    public class AthleteGetDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Regions Region { get; set; }
        public string Email { get; set; }
        public int SportId { get; set; }
        public string SportName { get; set; }
    }
}
