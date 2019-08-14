using Maru.Net.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maru.Net.Interfaces
{
    interface IClient
    {
        Uri BaseUrl { get; set; }
        string ApiKey { get; set; }
        WebClientHelper WebClient { get; set; }

        Task<IUser> GetUserAsync();

        Task<IBeatmapSet> GetBeatmapSetAsync();

        Task<IBeatmap> GetBeatmapAsync();

        Task<List<IScore>> GetTopScoresAsync();

        Task<List<IScore>> GetUserRecentScoresAsync();

        Task<List<IScore>> GetBestPerformanceAsync();

        Task<IMatch> GetMultiplayerMatchAsync();

        Task<IReplay> GetReplayAsync();
    }
}
