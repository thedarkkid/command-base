using CommandBase.Models;
using Microsoft.EntityFrameworkCore;

namespace CommandBase.Data.Contexts
{
    public class CommandBaseContext : DbContext
    {
        public CommandBaseContext(DbContextOptions<CommandBaseContext> opt) : base(opt)
        {
            
        }

        public DbSet<Command> Commands {get; set;}
    }
}
