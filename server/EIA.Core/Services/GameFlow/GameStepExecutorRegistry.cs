using EIA.Core.Services.GameFlow.Executors;

namespace EIA.Core.Services.GameFlow;

public class GameStepExecutorRegistry
{
    private readonly List<IGameStepExecutor> _executors;

    public GameStepExecutorRegistry()
    {
        _executors = new()
        {
            new DialogueStepExecutor(),

            new MissionStepExecutor(),

            new LaboratoryStepExecutor(),

            new LearningExperienceStepExecutor(),

            new RewardStepExecutor()
        };
    }

    public IGameStepExecutor? Find(GameStep step)
    {
        return _executors
            .FirstOrDefault(e => e.CanExecute(step));
    }

    public IEnumerable<IGameStepExecutor> All()
    {
        return _executors;
    }
}