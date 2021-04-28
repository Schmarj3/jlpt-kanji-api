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
        public JsonResult GetJlptKanji()
        {
            return new JsonResult(TempKanjiDataStore.Current.KanjiLists);
        }

        [HttpGet("{jlptlevel}")]
        public JsonResult GetJlptKanjiByLevel(int jlptlevel)
        {
            return new JsonResult(TempKanjiDataStore.Current.KanjiLists.FirstOrDefault(kanji => kanji.JLPTLevel == jlptlevel));
        }
    }
}
