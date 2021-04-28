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
            return new JsonResult(
                new List<object>()
                {
                    new {
                        id = 1, 
                        JLPTLevel = 5, 
                        Kanji = new List<string> { "ichi","ni" } 
                    },
                    new {
                        id = 2,
                        JLPTLevel = 4,
                        Kanji = new List<string> { "san","shi" }
                    }
                    ,
                    new {
                        id = 3,
                        JLPTLevel = 3,
                        Kanji = new List<string> { "go","roku" }
                    },
                    new {
                        id = 4,
                        JLPTLevel = 2,
                        Kanji = new List<string> { "nana","hachi" }
                    },
                    new {
                        id = 5,
                        JLPTLevel = 1,
                        Kanji = new List<string> { "kyuu","jyuu" }
                    }
                });
        }

        /*[HttpGet("{JLPTLevel}")]
        public JsonResult GetKanjiByLevel()
        {
            var KanjiList = new List<object>()
                {
                    new {
                        id = 1,
                        JLPTLevel = 5,
                        Kanji = new List<string> { "ichi","ni" }
                    },
                    new {
                        id = 2,
                        JLPTLevel = 4,
                        Kanji = new List<string> { "san","shi" }
                    }
                    ,
                    new {
                        id = 3,
                        JLPTLevel = 3,
                        Kanji = new List<string> { "go","roku" }
                    },
                    new {
                        id = 4,
                        JLPTLevel = 2,
                        Kanji = new List<string> { "nana","hachi" }
                    },
                    new {
                        id = 5,
                        JLPTLevel = 1,
                        Kanji = new List<string> { "kyuu","jyuu" }
                    }
                };

            var KanjiByLevel = KanjiList.FirstOrDefault(l => l.JLPTLevel == JLPTLevel)
            return
        }*/
    }
}
