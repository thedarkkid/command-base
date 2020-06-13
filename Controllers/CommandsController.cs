using System.Collections.Generic;
using AutoMapper;
using CommandBase.Data;
using CommandBase.Data.Interfaces;
using CommandBase.DTOs;
using CommandBase.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommandBase.Controllers

{   
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommandBaseRepo _repo;
        private readonly IMapper _mapper;


        public CommandsController(ICommandBaseRepo repository, IMapper mapper)
        {
            _repo = repository;
            _mapper = mapper;
        }
      
        [HttpGet]
        public ActionResult<IEnumerable<CommandReadDTO>> GetAllCommands(){
            IEnumerable<Command> commandItems = _repo.GetAllCommands();
            return Ok(_mapper.Map<IEnumerable<CommandReadDTO>>(commandItems));
        }

        [HttpGet("{id}")]
        public ActionResult<CommandReadDTO> GetCommandById(int id){
            Command commandItem = _repo.GetCommandById(id);

            if(commandItem == null) return NotFound();
            return Ok(_mapper.Map<CommandReadDTO>(commandItem));
        }
    }
}
