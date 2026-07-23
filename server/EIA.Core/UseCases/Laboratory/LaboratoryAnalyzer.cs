namespace EIA.Core.UseCases.Laboratory;

public class LaboratoryAnalyzer
{
    public double CalculateAverageVelocity(
        LaboratorySession session)
    {
        if (session.Records.Count == 0)
            return 0;

        return session.Records
            .Average(x => x.Velocity);
    }

    public double CalculateAverageDistance(
        LaboratorySession session)
    {
        if (session.Records.Count == 0)
            return 0;

        return session.Records
            .Average(x => x.Distance);
    }

    public double CalculateAverageTime(
        LaboratorySession session)
    {
        if (session.Records.Count == 0)
            return 0;

        return session.Records
            .Average(x => x.Time);
    }

    public bool IsUniformMotion(
        LaboratorySession session,
        double tolerance = 0.05)
    {
        if (session.Records.Count < 2)
            return false;

        var average =
            CalculateAverageVelocity(session);

        foreach (var row in session.Records)
        {
            if (Math.Abs(row.Velocity - average) > tolerance)
                return false;
        }

        return true;
    }
}