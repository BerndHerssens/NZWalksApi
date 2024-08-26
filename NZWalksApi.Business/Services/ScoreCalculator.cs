using NZWalksApi.Business.Enums;

namespace NZWalksApi.Business.Services
{
    public class ScoreCalculator : IScoreCalculator
    {
        public double CalculateWalkScore(double lengthInKm, BeautyGrade beautyGrade)
        {
            // Base score calculation based on walk length
            double baseScore = CalculateBaseScore(lengthInKm);

            // Percentage multiplier based on BeautyGrade (0 = 20%, 5 = 120%)
            double beautyMultiplier = GetBeautyGradeMultiplier(beautyGrade);

            // Final score calculation
            return Math.Round(baseScore * beautyMultiplier, 2);
        }

        // Calculate base score based on walk length
        private double CalculateBaseScore(double lengthInKm)
        {
            if (lengthInKm < 5)
            {
                return 0.5; // Lower score for short walks
            }
            if (lengthInKm is >= 5 and <= 10)
            {
                return 1.0; // Highest score for optimal length walks
            }
            else
            {
                return 0.75; // Reduced score for longer walks
            }
        }

        // Get the percentage multiplier based on the beauty grade
        private double GetBeautyGradeMultiplier(BeautyGrade beautyGrade)
        {
            switch (beautyGrade)
            {
                case BeautyGrade.Awful:
                    return 0.20;
                case BeautyGrade.SlightlyDirty:
                    return 0.40;
                case BeautyGrade.Normal:
                    return 0.60;
                case BeautyGrade.Pretty:
                    return 1;
                case BeautyGrade.MrPropreClean:
                    return 1.20;
                default:
                    throw new ArgumentOutOfRangeException(nameof(beautyGrade), "Unknown beauty grade");
            }
        }
    }
}
