using AEMTest.Models;
using AEMTest.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AEMTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class ValuesController : ControllerBase
    {
        public IPlatformWellService _platformService, _wellService;

        public ValuesController(IPlatformWellService service)
        {
            _platformService = _wellService = service;
        }

        //get all platform and well
        [HttpGet]
        [Route("[action]")]
        public IActionResult GetPlatformWellList()
        {
            try
            {
                var well = _wellService.GetPlatformWellList();
                if (well == null) return NotFound();
                return Ok(well);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        /// get platform details by id
        [HttpGet]
        [Route("[action]/id")]
        public IActionResult GetPlatformById(int id)
        {
            try
            {
                var platform = _platformService.GetPlatformDetailsById(id);
                if (platform == null) return NotFound();
                return Ok(platform);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        /// delete platform
        [HttpDelete]
        [Route("[action]")]
        public IActionResult DeletePlatform(int PlatformId)
        {
            try
            {
                var model = _platformService.DeletePlatform(PlatformId);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        /// get well details by id
        [HttpGet]
        [Route("[action]/id")]
        public IActionResult GetWellById(int WellId)
        {
            try
            {
                var well = _wellService.GetWellDetailsById(WellId);
                if (well == null) return NotFound();
                return Ok(well);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        /// delete well
        [HttpDelete]
        [Route("[action]")]
        public IActionResult DeleteWell(int WellId)
        {
            try
            {
                var model = _platformService.DeleteWell(WellId);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        /// save platform well
        [HttpPost]
        [Route("[action]")]
        public IActionResult SavePlatformWell(Well wellModel)
        {
            try
            {
                var model = _wellService.SavePlatformWell(wellModel);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        } 
    }
}
