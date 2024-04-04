using backend.Core.Enums;

namespace backend.Core.Dtos.Competition
{
    public class CompetitionGetDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public Rangs Rang { get; set; }
        public int SportId { get; set; }
        public string SportName { get; set; }

    }
}
