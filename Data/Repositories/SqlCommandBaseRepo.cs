using System;
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

        public void CreateCommand(Command cmd)
        {
            if(cmd == null) throw new ArgumentNullException(nameof(cmd));

            _context.Commands.Add(cmd);
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(p => p.id==id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
