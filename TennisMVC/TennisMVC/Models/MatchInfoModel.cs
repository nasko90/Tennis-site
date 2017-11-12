using System;
using System.Collections.Generic;

namespace TennisMVC.Models
{
    public class MatchInfoModel
    {
        List<string> Players { get; set; }
        public DateTime MatchDate { get; set; }
        public string Surface { get; set; }
        public List<int> HomePlayerSetResults { get; set; }
        public List<int> AwayPlayerSetResults { get; set; }
        public List<PlayerPositionModel> RankingInfo { get; set; }
    }
}