using System;
using System.Collections.Generic;
using System.Text;

namespace Maru.Net.Interfaces
{
    interface IBeatmap
    {
        // Beatmap/Beatmapset ID
        int BeatmapSetID { get; set; }
        int BeatmapID { get; set; }

        // Creator of the Map
        int CreatorID { get; set; }
        string CreatorName { get; set; }

        // Approval Info
        DateTime SubmitDate { get; set; }
        DateTime ApprovedDate { get; set; }
        DateTime LastUpdated { get; set; }
        ApprovalStatus Status { get; set; }

        // Mapset Info (or Map Info in case of mixes)
        string Title { get; set; }
        string Artist { get; set; }
        int BPM { get; set; }
        int LengthInSeconds { get; set; }
        string Source { get; set; }
        GenreID Genre { get; set; }
        LanguageID Language { get; set; }
        string FileHash { get; set; }

        // Map Info
        string DifficultyName { get; set; }
        Gamemode Mode { get; set; }
        string[] Tags { get; set; }
        int FavouriteCount { get; set; }
        decimal Rating { get; set; }
        int PlayCount { get; set; }
        int PassCount { get; set; }
        int HitcircleCount { get; set; }
        int SliderCount { get; set; }
        int SpinnerCount { get; set; }
        int MaxCombo { get; set; }
        bool IsDownloadable { get; set; }
        bool IsAvailable { get; set; }

        // Difficulty
        decimal StarRating { get; set; }
        decimal Aim { get; set; }
        decimal Speed { get; set; }
        decimal CircleSize { get; set; }
        decimal OverallDifficulty { get; set; }
        decimal ApproachRate { get; set; }
        decimal HealthDrain { get; set; }
        int DrainLengthInSeconds { get; set; }
    }
}
