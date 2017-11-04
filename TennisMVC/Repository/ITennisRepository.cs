using System.Collections.Generic;

namespace Repository
{
    public interface ITennisRepository
    {
        List<string> GetSurfaceTypes();
        List<string> GetPlayersNames();
    }
}
