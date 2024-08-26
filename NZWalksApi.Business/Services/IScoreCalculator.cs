using NZWalksApi.Business.Enums;

namespace NZWalksApi.Business.Services
{
    public interface IScoreCalculator
    {
        double CalculateWalkScore(double lengthInKm, BeautyGrade beautyGrade);
    }
}