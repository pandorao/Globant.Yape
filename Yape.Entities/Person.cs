using System.ComponentModel.DataAnnotations;
using Yape.Entities.Base;

namespace Yape.Entities
{
    public class Person : BaseModel
    {
        public string Id { get; set; }

        [Required]
        [MaxLength(200)]
        [Phone]
        public string CellPhoneNumber { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [Required]
        [MaxLength(200)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(3)]
        public string DocumentType { get; set; }

        [Required]
        [MaxLength(100)]
        public string DocumentNumber { get; set; }

        [Required]
        [MaxLength(500)]
        public string ReasonOfUse { get; set; }
    }
}
