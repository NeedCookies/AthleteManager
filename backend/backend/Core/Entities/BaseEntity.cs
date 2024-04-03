using System.ComponentModel.DataAnnotations;

namespace backend.Core.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(100)]
        [MinLength(3)]
        [RegularExpression(@"^[A-ZА-ЯЁ][a-zа-яё\-]*$", ErrorMessage = "Имя должно начинаться с заглавной буквы и содержать только латинские буквы или кириллицу")]
        public string Name { get; set; }
    }
}
