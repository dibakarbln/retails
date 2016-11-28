using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using fundu.Models;

namespace fundu.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
    
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.IncludeMetadataInDatabase = false;
        //}

        public DbSet<PostModel> PostModels { get; set; }
    }
}