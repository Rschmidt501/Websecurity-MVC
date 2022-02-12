using Microsoft.EntityFrameworkCore;
using Websecurity_MVC.Models;

namespace Websecurity_MVC.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
        }

        protected SqlContext()
        {
        }

        public virtual DbSet<Comment> Comments { get; set; }
    }
}
