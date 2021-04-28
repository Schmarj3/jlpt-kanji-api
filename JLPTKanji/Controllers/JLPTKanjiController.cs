using Microsoft.AspNetCore.Mvc;
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
        [HttpGet]
        public IActionResult GetJlptKanji()
        {
            return Ok(TempKanjiDataStore.Current.KanjiLists);
        }

        [HttpGet("{jlptlevel}")]
        public IActionResult GetJlptKanjiByLevel(int jlptlevel)
        {
            // find kanji level object
            var KanjiList = TempKanjiDataStore.Current.KanjiLists.FirstOrDefault(kanji => kanji.JLPTLevel == jlptlevel);

            if (KanjiList == null)
            {
                return NotFound();
            }

            return Ok(KanjiList);
        }
    }
}
