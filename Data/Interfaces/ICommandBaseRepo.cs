using System.Collections.Generic;
using CommandBase.Models;

namespace CommandBase.Data.Interfaces
{
    public interface ICommandBaseRepo
    {
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
    }
}