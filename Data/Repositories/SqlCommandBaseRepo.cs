using System.Collections.Generic;
using System.Linq;
using CommandBase.Data.Contexts;
using CommandBase.Data.Interfaces;
using CommandBase.Models;

namespace CommandBase.Data.Repositories
{
    public class SqlCommandBaseRepo : ICommandBaseRepo
    {
        private readonly CommandBaseContext _context;

        public SqlCommandBaseRepo(CommandBaseContext context)
        {
            _context = context;
        }
        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList()
        }

        public Command GetCommandById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
