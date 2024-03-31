using backend.Core.Enums;

namespace backend.Core.Entities
{
    public class Athlete : BaseEntity
    {
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Regions Region { get; set; }
        public string Email { get; set; }

        public int SportId { get; set; }

        public List<Competition> Competitions { get; set; }
    }
}
