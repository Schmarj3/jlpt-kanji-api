using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JLPTKanji.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JLPTKanjiController : ControllerBase
    {
        private readonly ILogger<JLPTKanjiController> _logger;
        public JLPTKanjiController(ILogger<JLPTKanjiController> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet]
        public IActionResult GetJlptKanji()
        {
            return Ok(TempKanjiDataStore.Current.KanjiLists);
        }

        [HttpGet("{jlptlevel}")]
        public IActionResult GetJlptKanjiByLevel(int jlptlevel)
        {
            try
            {
                // find kanji level object
                var KanjiList = TempKanjiDataStore.Current.KanjiLists.FirstOrDefault(kanji => kanji.JLPTLevel == jlptlevel);

                if (KanjiList == null)
                {
                    _logger.LogInformation($"JLPT level N{jlptlevel} wasn't found when accessing the list of kanji.");
                    return NotFound();
                }

                return Ok(KanjiList);
            }
            catch (Exception ex)
            {
                _logger.LogCritical($"Exception while getting kanji by level with a KanjiLevel of N{jlptlevel}.", ex);
                return StatusCode(500, "A problem occured while handing your request");
            }

        }
    }
}
