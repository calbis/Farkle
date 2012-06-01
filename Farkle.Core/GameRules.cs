namespace Farkle.Core
{
    public class GameRules
    {
        public GameRules()
        {
            // default rules
            WinningScore = 10000;
            ThresholdStartingScore = 500;
            NuberOfDice = 5;
        }

        public int WinningScore { get; set; }
        public int ThresholdStartingScore { get; set; }
        public int NuberOfDice { get; set; }
    }
}