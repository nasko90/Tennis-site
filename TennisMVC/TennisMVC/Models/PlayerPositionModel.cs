using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TennisMVC.Models
{
    public class PlayerPositionModel
    {
        public string Name { get; set; }
        public int PositionInRanking { get; set; }
        public List<string> Form { get; set; }
        public int Wins { get; set; }
        public int Draws { get; set; }
        public int Loss { get; set; }
        public int Points { get; set; }
    }
}