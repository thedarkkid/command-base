using AutoMapper;
using CommandBase.DTOs;
using CommandBase.Models;

namespace CommandBase.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            CreateMap<Command, CommandReadDTO>();
            CreateMap<CommandCreateDTO, Command>();
        }
    }
}
