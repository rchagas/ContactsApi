using BrunskerApi.Services.Exceptions;
using ContactsApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactsApi.Services {

    public class UserService
    {
        public readonly ContactApiContext context;
        public UserService(ContactApiContext context)
        {
            this.context = context;
        }
        public async Task<List<User>> FindAllAsync()
        {
            return await context.Users.Include(user => user.Contacts).ToListAsync();
        }
        public async Task<int> AddAsync (User user) 
        {
            if (user == null)
                throw new ArgumentNullException("user");
            if (user.Name == "" && user.Contacts.Count == 0)
                throw new ArgumentException("Empty Data");
            context.Users.Add(user);
            return await context.SaveChangesAsync();
        }
        public async Task<int> UpdateAsync(User user) {
            bool hasAny = await context.Users.AnyAsync(obj => obj.Id == user.Id);
            if (!hasAny)
                throw new NotFoundException("Id not Found");
            try {
                context.Users.Update(user);
                return await context.SaveChangesAsync();
            }
            catch (DbConcurrencyException ex) 
            {
                throw new DbConcurrencyException(ex.Message);
            }
        }
        public Task<User> FindByIdAsync(int id) {
            var result = context.Users.Include(user => user.Contacts)
                .FirstOrDefaultAsync(obj => obj.Id == id);
            if (result == null)
                throw new NotFoundException("Id not Found");
            else return result;
        }
        public async Task DeleteAsync(int id) {
            var obj = await FindByIdAsync(id);
            context.Remove(obj);
            await context.SaveChangesAsync();
        }

        public async Task DeleteContactAsync(int id) {
            var obj = await context.Contacts.FindAsync(id);
            context.Remove(obj);
            await context.SaveChangesAsync();
        }
    }
}
