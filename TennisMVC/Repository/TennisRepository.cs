using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
