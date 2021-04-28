using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JLPTKanji.Model
{
    public class KanjiByLevelPOCO
    {
        /*public KanjiByLevelModel(int id, int jlptlevel, List<string> kanji)
        {
            Id = id;
            JLPTLevel = jlptlevel;
            Kanji = kanji;

        }

        private KanjiByLevelModel()
        {

        }*/

        public int Id { get; set; }
        public int JLPTLevel { get; set; }
        public List<string> Kanji { get; set; }

    }
}
