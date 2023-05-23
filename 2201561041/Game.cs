using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2201561041
{
    internal class Game
    {
        public Team Team1 {get;set;}
        public Team Team2 {get;set;}
        public string Referee { get; set; }
        public string AssistantReferee1 { get; set; }
        public string AssistantReferee2 { get; set; }
        public int Goals { get; set; }
        public int Minute { get; set; }
        
        public int GameResult { get; set; } 
        public string Winner { get; set; }
    }
}
