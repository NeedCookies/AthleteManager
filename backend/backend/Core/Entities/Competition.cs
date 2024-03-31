using backend.Core.Enums;

namespace backend.Core.Entities
{
    public class Competition : BaseEntity
    {
        public DateTime Date { get; set; }
        public List<Athlete> Winners { get; set; }
        public List<int> Prizes { get; set; }
        public Rangs Rang { get; set; }

        public int SportId { get; set; }
        public Sport Sport { get; set; }

        public ICollection<Athlete> Athletes { get; set; } 
    }
}
