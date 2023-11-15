using LostShadow.Feature.AdventureScene.AdventureStage.Model;

namespace LostShadow.Feature.AdventureScene.AdventureInteractable.Model
{
    public class AdventureInteractableModel
    {
        public AdventureStageModel ConnectedAdventureStage;
        public InteractionType InteractionType;
    }

    public enum InteractionType
    {
        NavigateAdventureStage,
        TryClaimingObject,
        TryPuttingObject,
        OperatePuzzlePiece
    }
}