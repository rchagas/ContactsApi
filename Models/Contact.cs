using System.ComponentModel.DataAnnotations;

namespace ContactsApi.Models {
    public class Contact {
        [Key]
        public int Id { get; set; }
        [Required]
        public ContactType Type { get; set; }
        [Required]
        [StringLength(100)]
        public string Value { get; set; }
        [Required]
        public int UserId { get; set; }

        public Contact() { }
    }
}
