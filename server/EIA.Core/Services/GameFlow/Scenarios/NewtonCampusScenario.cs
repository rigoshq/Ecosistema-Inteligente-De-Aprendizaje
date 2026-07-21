using EIA.Core.Services.GameFlow.Enums;

namespace EIA.Core.Services.GameFlow.Scenarios;

public static class NewtonCampusScenario
{
    public static GameStage Create()
    {
        var stage = new GameStage("Campus Newton");

        stage.AddStep(
            new GameStep(
                "Talk with Professor Newton",
                GameStepType.Dialogue));

        stage.AddStep(
            new GameStep(
                "Accept Mission",
                GameStepType.Mission));

        stage.AddStep(
            new GameStep(
                "Enter MRU Laboratory",
                GameStepType.Laboratory));

        stage.AddStep(
            new GameStep(
                "Complete Learning Experience",
                GameStepType.LearningExperience));

        stage.AddStep(
            new GameStep(
                "Receive Reward",
                GameStepType.Reward));

        stage.AddStep(
            new GameStep(
                "Scenario Completed",
                GameStepType.Completed));

        return stage;
    }
}