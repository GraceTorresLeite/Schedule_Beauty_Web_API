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
    // [ApiVersion("1")]
    [ApiController]
   // [Route("api/v{version:apiVersion}/[controller]")]
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

        // GET: api/ScheduleFormAPI
        [HttpGet]
        [ProducesResponseType((200), Type = typeof(List<ScheduleFormVO>))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HypermediaFilter))]
        public async Task<ActionResult<IEnumerable<ScheduleFormVO>>> GetSchedulesForms()
        {
            return Ok(_scheduleFormsBusiness.FindAll());
        }

        // GET: api/ScheduleFormAPI/5
        [HttpGet("{id}")]
        [ProducesResponseType((200), Type = typeof(ScheduleFormVO))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HypermediaFilter))]
        public async Task<ActionResult<ScheduleFormVO>> GetScheduleForm(long id)
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
        public async Task<ActionResult<ScheduleFormVO>> GetScheduleForm([FromQuery] string name)
        {
            var scheduleForm = _scheduleFormsBusiness.FindByName(name);

            if (scheduleForm == null) return NotFound();

            return Ok(scheduleForm);
        }

        // PUT: api/ScheduleFormAPI/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize("Bearer")]
        [ProducesResponseType((200), Type = typeof(ScheduleFormVO))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HypermediaFilter))]
        public async Task<IActionResult> PutScheduleForm(long id, ScheduleFormVO scheduleFormVO)
        {
            if (scheduleFormVO == null) return BadRequest();
            var updateScheduleForm = _scheduleFormsBusiness.Update(scheduleFormVO);
            return Ok(updateScheduleForm);
        }

            // POST: api/ScheduleFormAPI
            // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [ProducesResponseType((200), Type = typeof(ScheduleFormVO))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HypermediaFilter))]
        public async Task<ActionResult<ScheduleFormVO>> PostScheduleForm(ScheduleFormVO scheduleFormVO)
        {
            if (scheduleFormVO == null) return BadRequest();
            var createScheduleForm = _scheduleFormsBusiness.Create(scheduleFormVO);
            return Ok(createScheduleForm);
        }

        // DELETE: api/ScheduleFormAPI/5
        [HttpDelete("{id}")]
        [Authorize("Bearer")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public async Task<IActionResult> DeleteScheduleForm(long id)
        {
            _scheduleFormsBusiness.Delete(id);
            return NoContent();
        }

        [HttpPatch("{id}")]
        [Authorize("Bearer")]
        [ProducesResponseType((200), Type = typeof(ScheduleFormVO))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HypermediaFilter))]
        public async Task<IActionResult> PatchScheduleForm(long id)
        {
            var scheduleForm = _scheduleFormsBusiness.Disable(id);
            return Ok(scheduleForm);
        }
    }
}
