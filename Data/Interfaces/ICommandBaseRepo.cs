using System.Collections.Generic;
using CommandBase.Models;

namespace CommandBase.Data.Interfaces
{
    public interface ICommandBaseRepo
    {
        bool SaveChanges();
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        void CreateCommand(Command cmd);

    }
}