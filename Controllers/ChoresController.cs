
namespace choreScore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChoresController : ControllerBase
    {
        private readonly ChoresService _choreService;

        public ChoresController(ChoresService choresService)
        {
            _choreService = choresService;
        }

        [HttpGet]
        public ActionResult<List<Chore>> GetChores()
        {
            try
            {
                List<Chore> chores = _choreService.GetChores();
                return Ok(chores);   
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{choreTitle}")]
        public ActionResult<Chore> GetChoreByName(string choreTitle)
        {
            try
            {
                Chore chore = _choreService.GetChoreByName(choreTitle);
                return Ok(chore);
            }
            catch (Exception e)
            {
                    return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public ActionResult<Chore> CreateChore([FromBody] Chore choreData)
        {
            try
            {
                Chore chore = _choreService.createChore(choreData);
                return Ok(chore);
            }
            catch (Exception e)
            {
                
                return BadRequest(e.Message);
            }
        }
        [HttpDelete("{choreTitle}")]
        public ActionResult<Chore> RemoveChore(string choreTitle)
        {
            try
            {
                Chore chore = _choreService.Removechore(choreTitle);
                return Ok(chore);
            }
            catch (Exception e) 
            {
                
                return BadRequest(e.Message);
            }
        }
        [HttpPut("{choreTitle}")]
        public ActionResult<Chore> ChangeChore(string choreTitle , [FromBody] Chore choreData)
        {
            try
            {
                Chore chore = _choreService.ChangeChore(choreTitle, choreData);
                return chore;
            }
            catch (Exception e)
            {
                
                return BadRequest(e.Message);
            }
        }
    }
}