namespace EIA.Core.Intelligence;

public class ExplorerLearningProfile
{
    //--------------------------------------------------------
    // Rendimiento académico
    //--------------------------------------------------------

    public double AverageScore { get; private set; }

    public double AverageTimeMinutes { get; private set; }

    public int TotalAttempts { get; private set; }

    public int CompletedActivities { get; private set; }

    //--------------------------------------------------------
    // Comportamiento
    //--------------------------------------------------------

    public int HelpRequests { get; private set; }

    public int IndependentSolutions { get; private set; }

    //--------------------------------------------------------
    // Competencias observadas
    //--------------------------------------------------------

    private readonly Dictionary<string,double> _competencies;

    public IReadOnlyDictionary<string,double> Competencies
        => _competencies;

    public ExplorerLearningProfile()
    {
        _competencies = new();
    }

    //--------------------------------------------------------
    // Actualiza el perfil usando una evidencia
    //--------------------------------------------------------

    public void RegisterEvidence(
        LearningEvidence evidence)
    {
        CompletedActivities++;

        AverageScore =
            ((AverageScore * (CompletedActivities - 1))
            + evidence.Score)
            / CompletedActivities;

        AverageTimeMinutes =
            ((AverageTimeMinutes * (CompletedActivities - 1))
            + evidence.TimeSpentMinutes)
            / CompletedActivities;

        TotalAttempts += evidence.Attempts;

        if (evidence.NeededHelp)
            HelpRequests++;
        else
            IndependentSolutions++;

        if (!_competencies.ContainsKey(evidence.Competency))
        {
            _competencies[evidence.Competency] =
                evidence.Score;
        }
        else
        {
            _competencies[evidence.Competency] =
                (_competencies[evidence.Competency]
                + evidence.Score) / 2.0;
        }
    }
}