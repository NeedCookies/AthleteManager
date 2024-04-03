using backend.Core.Enums;

namespace backend.Core.Entities
{
    public class Competition : BaseEntity
    {
        public DateTime Date { get; set; }
        public int WinnerId { get; set; }
        public Athlete Winner { get; set; }
        public Rangs Rang { get; set; }

        public int SportId { get; set; }
        public Sport Sport { get; set; }

        public ICollection<Athlete> Competitors { get; set; } 
    }
}
