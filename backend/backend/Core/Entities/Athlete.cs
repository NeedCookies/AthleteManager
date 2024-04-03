using backend.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace backend.Core.Entities
{
    public class Athlete : BaseEntity
    {
        [MaxLength(100)]
        [MinLength(3)]
        [RegularExpression(@"^[A-ZА-ЯЁ][a-zа-яё\-]*$", ErrorMessage = "Имя должно начинаться с заглавной буквы и содержать только латинские буквы или кириллицу")]
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Regions Region { get; set; }
        [MaxLength(150)]
        [MinLength(3)]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Некорректный Email")]
        public string Email { get; set; }

        public ICollection<Competition> competitions { get; set; }
        public int SportId { get; set; }
        public Sport Sport { get; set; }
    }
}
