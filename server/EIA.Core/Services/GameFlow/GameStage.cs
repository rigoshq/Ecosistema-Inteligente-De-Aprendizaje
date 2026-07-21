namespace EIA.Core.Services.GameFlow;

public class GameStage
{
    public Guid Id { get; }

    public string Name { get; }

    public List<GameStep> Steps { get; }

    public GameStage(string name)
    {
        Id = Guid.NewGuid();

        Name = name;

        Steps = new();
    }

    public void AddStep(GameStep step)
    {
        Steps.Add(step);
    }
}