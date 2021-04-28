using JLPTKanji.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JLPTKanji
{
    public class TempKanjiDataStore
    {
        public static TempKanjiDataStore Current { get; } = new TempKanjiDataStore();
        public List<KanjiByLevelPOCO> KanjiLists { get; set; }

       public TempKanjiDataStore()
        {
            // init dummy data
            KanjiLists = new List<KanjiByLevelPOCO>()
                {
                    new KanjiByLevelPOCO
                    {
                        Id = 1,
                        JLPTLevel = 5,
                        Kanji = new List<string> { "ichi","ni" }
},
                    new KanjiByLevelPOCO
                    {
                        Id = 2,
                        JLPTLevel = 4,
                        Kanji = new List<string> { "san", "shi" }
                    }
                    ,
                    new KanjiByLevelPOCO
                    {
                        Id = 3,
                        JLPTLevel = 3,
                        Kanji = new List<string> { "go", "roku" }
                    },
                    new KanjiByLevelPOCO
                    {
                        Id = 4,
                        JLPTLevel = 2,
                        Kanji = new List<string> { "nana", "hachi" }
                    },
                    new KanjiByLevelPOCO
                    {
                        Id = 5,
                        JLPTLevel = 1,
                        Kanji = new List<string> { "kyuu", "jyuu" }
                    }
                };
        }
    }
}
