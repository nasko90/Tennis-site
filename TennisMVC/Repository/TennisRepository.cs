using Models;
using System.Collections.Generic;
using System.Linq;
using TennisDb;

namespace Repository
{
    public class TennisRepository : ITennisRepository
    {
        private readonly TennisEntities _tennisEntities;
        public TennisRepository()
        {
            _tennisEntities = new TennisEntities();
        }

        public List<string> GetSurfaceTypes()
        {
            var surfaces = _tennisEntities.Surfaces.Select(x => x.Name);
            return surfaces.ToList();
        }

        public List<string> GetPlayersNames()
        {
            var playersNames = _tennisEntities.Players.Select(x => x.Name);
            return playersNames.ToList();
        }

        public bool AddMatch(GameInfo gameInfo)
        {
            try
            {
                var surface = _tennisEntities.Surfaces.First(x => x.Name == gameInfo.Surface);
                var matchOutcome = CalculateMatchResult(gameInfo);
                var match = new Match
                {
                    Date = gameInfo.MatchDate,
                    Surface = surface,
                };

                var a = _tennisEntities.Players.Single(x => x.Id == 1);
                var playerOne = _tennisEntities.Players.Single(x => x.Name == gameInfo.Players[0].Name);
                var playrOneResult = SetPlayerSetsResulst(gameInfo.Players[0]);
                playrOneResult.Player = playerOne;
                playrOneResult.Match = match;
                playrOneResult.Outcome = _tennisEntities.Outcomes.First(x => x.Name == matchOutcome[1]);

                var playerTwo = _tennisEntities.Players.First(x => x.Name == gameInfo.Players[1].Name);
                var playrTwoResult = SetPlayerSetsResulst(gameInfo.Players[1]);
                playrTwoResult.Player = playerTwo;
                playrTwoResult.Match = match;
                playrTwoResult.Outcome = _tennisEntities.Outcomes.First(x => x.Name == matchOutcome[1]);

                _tennisEntities.PlayerResults.Add(playrOneResult);
                _tennisEntities.PlayerResults.Add(playrTwoResult);

                _tennisEntities.SaveChanges();

                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }
           
        }

        private PlayerResult SetPlayerSetsResulst(PlayerModel playerModel)
        {
            var playerOneResult = new PlayerResult
            {
                FirstSet = playerModel.SetsResult[0],
                SecondSet = playerModel.SetsResult[1],
                ThirdSet = playerModel.SetsResult[2]
            };

            return playerOneResult;
        }

        private List<string> CalculateMatchResult(GameInfo gameInfo)
        {
            var playerOneSetsWon = 0;
            var playerTwoSetsWon = 0;
            var playerOneResult = gameInfo.Players[0].SetsResult;
            var playerTwoResult = gameInfo.Players[1].SetsResult;
            var result = new List<string>();

            for (int i = 0; i < 3; i++)
            {
                if (playerOneResult[i] > playerTwoResult[i])
                {
                    playerOneSetsWon++;
                }

                if (playerTwoResult[i] > playerOneResult[i])
                {
                    playerTwoSetsWon++;
                }
            }

            if (playerOneSetsWon > playerTwoSetsWon)
            {
                result.AddRange(new string[] { "W", "L" });
            }
            else if (playerOneSetsWon == playerTwoSetsWon)
            {
                result.AddRange(new string[] { "D", "D" });
            }
            else
            {
                result.AddRange(new string[] { "L", "W" });
            }

            return result;
        }
    }
}
