using System;
using System.Linq;
using System.Text;
using MatchEntities.Enums;

namespace Database
{
    public static class MatchContextExtensions
    {
        public static MatchMakingRank CurrentRank(this MatchContext dbContext, long playerId)
        {
            return dbContext.PlayerMatchStats
                       .Where(x => x.SteamId == playerId && x.MatchStats.AvgRank != null && x.MatchStats.Source == Source.Valve)
                       .OrderByDescending(x => x.MatchStats.MatchDate)
                       .Select(x => x.RankAfterMatch)
                       .FirstOrDefault();
        }
    }
}
