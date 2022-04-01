using System;
using System.Collections.Generic;
using System.Text;

namespace UplayFalso
{
    class Software
    {
        public string TypeTool;
        public DateTime Start;
        public DateTime EndAiring;
        public List<string> Seasons;
        public float SeasonsLength;
    }
    public class Tools : Software
    {
        public string ToolType;
    }
    public class Game : Software
    {
        public int MetaCritic;
        public float AveragePlayTime;
        public string DLC;
    }
}
