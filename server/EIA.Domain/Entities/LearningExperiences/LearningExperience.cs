using EIA.Domain.Entities.LearningExperiences.Enums;

namespace EIA.Domain.Entities.LearningExperiences;

public class LearningExperience
{
    public Guid Id { get; private set; }

    public string Title { get; private set; }

    public string Description { get; private set; }

    public LearningDifficulty Difficulty { get; private set; }

    public LearningMode Mode { get; private set; }

    public LearningState State { get; private set; }

    public bool Active { get; private set; }

    public List<LearningStage> Stages { get; }

    public List<LearningObjective> Objectives { get; }

    public List<LearningAssessment> Assessments { get; }

    public List<LearningFeedback> Feedbacks { get; }

    public List<LearningReward> Rewards { get; }

    public LearningProgress Progress { get; private set; }

    private LearningExperience()
    {
        Id = Guid.NewGuid();

        Title = string.Empty;

        Description = string.Empty;

        Difficulty = LearningDifficulty.Beginner;

        Mode = LearningMode.Guided;

        State = LearningState.Locked;

        Active = true;

        Stages = new();

        Objectives = new();

        Assessments = new();

        Feedbacks = new();

        Rewards = new();

        Progress = new LearningProgress();
    }

    public LearningExperience(
        string title,
        string description,
        LearningDifficulty difficulty,
        LearningMode mode)
        : this()
    {
        Title = title;

        Description = description;

        Difficulty = difficulty;

        Mode = mode;

        State = LearningState.Available;
    }

    public void AddStage(LearningStage stage)
    {
        Stages.Add(stage);
    }

    public void AddObjective(LearningObjective objective)
    {
        Objectives.Add(objective);
    }

    public void AddAssessment(LearningAssessment assessment)
    {
        Assessments.Add(assessment);
    }

    public void AddFeedback(LearningFeedback feedback)
    {
        Feedbacks.Add(feedback);
    }

    public void AddReward(LearningReward reward)
    {
        Rewards.Add(reward);
    }

    public void UpdateProgress(double percentage)
    {
        Progress.Update(percentage);
    }

    public void Start()
    {
        State = LearningState.InProgress;
    }

    public void Complete()
    {
        State = LearningState.Completed;
    }

    public void Activate()
    {
        Active = true;
    }

    public void Deactivate()
    {
        Active = false;
    }
}