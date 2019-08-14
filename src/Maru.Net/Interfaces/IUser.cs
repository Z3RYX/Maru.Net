using System;
using System.Collections.Generic;
using System.Text;

namespace Maru.Net.Interfaces
{
    interface IUser
    {
        int UserID { get; set; }
        string Username { get; set; }
        DateTime JoinDate { get; set; }
        int Count300 { get; set; }
        int Count100 { get; set; }
        int Count50 { get; set; }
        int PlayCount { get; set; }
        long RankedScore { get; set; }
        long TotalScore { get; set; }
        int PerformanceRank { get; set; }
        decimal Level { get; set; }
        decimal PP_Raw { get; set; }
        decimal Accuracy { get; set; }
        int SS_Count { get; set; }
        int SSH_Count { get; set; }
        int S_Count { get; set; }
        int SH_Count { get; set; }
        int A_Count { get; set; }
        string Country { get; set; }
        TimeSpan TotalPlaytime { get; set; }
        int CountryPerformanceRank { get; set; }
        List<IEvent> Events { get; set; }
    }
}
