using LostShadow.Feature.AdventureScene.AdventureInteractable.Model;
using LostShadow.Feature.AdventureScene.AdventureStage.Model;

namespace LostShadow.Feature.AdventureScene.Navigation.Model
{
    public class NavigationModel : AdventureInteractableModel
    {
        public AdventureStageModel StageToNavigate;
        public bool IsNavigatable;
        }
}