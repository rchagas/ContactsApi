using System.ComponentModel.DataAnnotations;

namespace ContactsApi.Models {
    public class User {
        [Key]
        public int Id { get; set; }
        [Required(AllowEmptyStrings=true)]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        public List<Contact> Contacts { get; set; }

        public User() { }
    }
}
