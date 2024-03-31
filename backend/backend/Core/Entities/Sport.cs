namespace backend.Core.Entities
{
    public class Sport : BaseEntity
    {
        public ICollection<Competition> Competitions { get; set; }
        public ICollection<Athlete> Athletes { get; set; }
    }
}
