using System.Collections.Generic;
using CommandBase.Data;
using CommandBase.Data.Interfaces;
using CommandBase.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommandBase.Controllers

{   
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommandBaseRepo _repo;

        public CommandsController(ICommandBaseRepo repository)
        {
            _repo = repository;
        }
      
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands(){
            IEnumerable<Command> commandItems = _repo.GetAllCommands();
            return Ok(commandItems);
        }

        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id){
            Command commandItem = _repo.GetCommandById(id);
            return Ok(commandItem);

        }
    }
}
