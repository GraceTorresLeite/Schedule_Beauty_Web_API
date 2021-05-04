using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebServiceApi.Business;
using WebServiceApi.Data.VO;
using WebServiceApi.Hypermedia.Filters;

namespace WebServiceApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ScheduleFormAPIController : ControllerBase
    {
        private readonly ILogger<ScheduleFormAPIController> _logger; 
        private IScheduleFormsBusiness _scheduleFormsBusiness;

        public ScheduleFormAPIController(ILogger<ScheduleFormAPIController> logger, IScheduleFormsBusiness scheduleFormsBusiness)
        {
            _logger = logger;
            _scheduleFormsBusiness = scheduleFormsBusiness;
        }
        [HttpGet()]
        [ProducesResponseType((200), Type = typeof(List<ScheduleFormVO>))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HypermediaFilter))]
        public IActionResult Get()
        {
            return Ok(_scheduleFormsBusiness.FindAll());
        }

        [HttpGet("{id}")]
        [ProducesResponseType((200), Type = typeof(ScheduleFormVO))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HypermediaFilter))]
        public IActionResult Get(long id)
        {
            var scheduleForm = _scheduleFormsBusiness.FindByID(id);

            if (scheduleForm == null) return NotFound();

            return Ok(scheduleForm);
        }

        [HttpGet("findScheduleFormByName")]
        [ProducesResponseType((200), Type = typeof(ScheduleFormVO))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HypermediaFilter))]
        public IActionResult Get([FromQuery] string name)
        {
            var scheduleForm = _scheduleFormsBusiness.FindByName(name);

            if (scheduleForm == null) return NotFound();

            return Ok(scheduleForm);
        }

        [HttpPost]
        [ProducesResponseType((200), Type = typeof(ScheduleFormVO))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HypermediaFilter))]
        public IActionResult Post([FromBody] ScheduleFormVO scheduleFormVO)
        {
            if (scheduleFormVO == null) return BadRequest();
            var createScheduleForm = _scheduleFormsBusiness.Create(scheduleFormVO);
            return Ok(createScheduleForm);
        }

        [HttpPut]
        [Authorize("Bearer")]
        [ProducesResponseType((200), Type = typeof(ScheduleFormVO))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HypermediaFilter))]
        public IActionResult Put([FromBody] ScheduleFormVO scheduleFormVO)
        {
            if (scheduleFormVO == null) return BadRequest();
            var updateScheduleForm = _scheduleFormsBusiness.Update(scheduleFormVO);
            return Ok(updateScheduleForm);
        }

        [HttpPatch("{id}")]
        [Authorize("Bearer")]
        [ProducesResponseType((200), Type = typeof(ScheduleFormVO))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HypermediaFilter))]
        public IActionResult Patch(long id)
        {
            var scheduleForm = _scheduleFormsBusiness.Disable(id);
            return Ok(scheduleForm);
        }

        [HttpDelete("{id}")]
        [Authorize("Bearer")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public IActionResult Delete(long id)
        {
            _scheduleFormsBusiness.Delete(id);
            return NoContent();
        }
    }
}

