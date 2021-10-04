using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using back_end.ViewModels;
using back_end.DAL;

namespace back_end.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemRepo _repo;
        public ItemController(IItemRepo _taskRepo)
        {
            _repo = _taskRepo;
        }

        [HttpGet]
        [Route("all"), ActionName("taskOverview")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetAllTasks()
        {
            return Ok(_repo.GetAllItems());
        }

        [HttpGet]
        [Route("{id}"), ActionName("itemById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetItemById(int id)
        {
            return Ok();
        }

        [HttpPost]
        [Route("create"), ActionName("createItem")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult CreateTask([FromBody] ItemViewModel tvm)
        {
            return CreatedAtAction("itemById", new { id = tvm.ID }, tvm);
        }
    }
}