using System.Collections.Generic;
using CommandBase.Data.Interfaces;
using CommandBase.Models;

namespace CommandBase.Data.Repositories                                 
{
    public class MockCommandBaseRepo : ICommandBaseRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{id=0, HowTo="Boil sumn", Line="Boil Water", Platform="Kettle & Pan"},
                new Command{id=1, HowTo="Cut Bread", Line="Get a Knife", Platform="Knife and chopping board"},
                new Command{id=2, HowTo="Make cup of tea", Line="Boil Water and add leaf", Platform="Kettle"},
                new Command{id=3, HowTo="Make Cocktail", Line="Mix Drinks", Platform="Shaker"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{id=0, HowTo="Boil sumn", Line="Boil Water", Platform="Kettle & Pan"};
        }
    }
}