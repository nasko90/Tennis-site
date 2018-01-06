using System;
using System.Collections.Generic;

namespace Models
{
    public class GameInfo
    {
        public PlayerModel[] Players { get; set; }
        public DateTime MatchDate { get; set; }
        public string Surface { get; set; }
    }
}
