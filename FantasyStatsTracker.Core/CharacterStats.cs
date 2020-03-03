using System;

namespace FantasyStatsTracker.Core
{
    public class CharacterStats
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public int Level { get; set; }
        public string Background { get; set; }
        public string PlayerName { get; set; }
        public Alignments Alignment { get; set; }
        public string Race { get; set; }
    }
}