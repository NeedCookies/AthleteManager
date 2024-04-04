using backend.Core.Entities;

namespace backend.Core.Dtos.Sport
{
    public class SportGetDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Entities.Competition> Competitions { get; set; }

        public ICollection<Entities.Athlete> Athletes { get; set; }
    }
}
