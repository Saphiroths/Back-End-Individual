using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskService.ViewModels;
using TaskService.DAL;

using TaskService.Logic;


namespace TaskService.Controllers
{
    [Route("item")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly ItemLogic _itemLogic;
        public ItemController(ItemLogic itemlogic)
        {
            _itemLogic = itemlogic;
        }

        [HttpGet]
        [Route("all"), ActionName("taskOverview")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetAllTasks()
        {
            return Ok(_itemLogic.GetAllItems());
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
        [Route("create")]
        public async Task<ActionResult<ItemViewModel>> CreateItem([FromBody] ItemViewModel item)
        {
            if (item.Title != null && item.Description != null)
            {
                _itemLogic.NewItem(item);
                return CreatedAtAction("CreateItem", item);
            }
            return StatusCode(404, "Not all fields are filled in");
        }

        [HttpPut]
        [Route("update")]
        public IActionResult UpdateItem([FromBody] ItemViewModel item)
        {

            if (item.Title != null && item.Description != null)
            {
                _itemLogic.UpdateItem(item);              
            }
            return Ok(_itemLogic.GetAllItems());
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public async Task<ActionResult<ItemViewModel>> DeleteItem(int id)
        {
            _itemLogic.DeleteItem(id);
            return NoContent();
        }
    }
}