using LostShadow.Feature.AdventureScene.AdventureInteractables.Navigation.NavigationRepository;
using LostShadow.Feature.AdventureScene.AdventureStage.Model;
using LostShadow.Feature.AdventureScene.AdventureStage.Service;
using LostShadow.Feature.AdventureScene.Navigation.Model;

namespace LostShadow.Feature.AdventureScene.AdventureInteractable.Navigation.Service
{
    public class NavigationService
    {
        private readonly NavigationRepository _navigationRepository;
        private readonly AdventureStageService _adventureStageService;

        public NavigationService(
            NavigationRepository navigationRepository,
            AdventureStageService adventureStageService)
        {
            _navigationRepository = navigationRepository;
            _adventureStageService = adventureStageService;
        }

        public AdventureStageModel GetAdventureStageModelFromNavigationModel(NavigationModel navigationModel)
        {
            return _adventureStageService.GetAdventureStageRepository()
                .GetAdventureStageModelById(navigationModel.ConnectedAdventureStage.Id);
        }
    }
}