using Microsoft.EntityFrameworkCore;

namespace ContactsApi.Models 
{
    public class ContactApiContext: DbContext 
    {
        public ContactApiContext(DbContextOptions<ContactApiContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }        
        public DbSet<Contact> Contacts { get; set; }
    }
}
