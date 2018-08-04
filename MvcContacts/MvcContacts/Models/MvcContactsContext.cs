using Microsoft.EntityFrameworkCore;

namespace MvcContacts.Models
{
    public class MvcContactsContext : DbContext
    {
        public MvcContactsContext(DbContextOptions<MvcContactsContext> options)
            : base(options)
        {
        }

        public DbSet<MvcContacts.Models.Contacts> Contacts { get; set; }
    }
}