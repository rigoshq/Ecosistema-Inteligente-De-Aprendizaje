using EIA.Domain.Entities.Interactions.Enums;

namespace EIA.Domain.Entities.Interactions;

public class InteractionResponse
{
    public string Message { get; }

    public InteractionResult Result { get; }

    public InteractionResponse(
        string message,
        InteractionResult result)
    {
        Message = message;

        Result = result;
    }
}