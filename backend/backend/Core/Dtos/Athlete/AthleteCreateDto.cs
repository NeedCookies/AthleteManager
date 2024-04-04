using backend.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace backend.Core.Dtos.Athlete
{
    public class AthleteCreateDto
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Regions Region { get; set; }
        public string Email { get; set; }
        public int SportId { get; set; }
    }
}
