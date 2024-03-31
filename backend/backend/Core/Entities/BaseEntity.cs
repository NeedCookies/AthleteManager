using System.ComponentModel.DataAnnotations;

namespace backend.Core.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
