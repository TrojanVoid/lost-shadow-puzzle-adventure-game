using LostShadow.Feature.AdventureScene.AdventureStage.Model;
using LostShadow.Feature.AdventureScene.AdventureStage.Repository;

namespace LostShadow.Feature.AdventureScene.AdventureStage.Service
{
    public class AdventureStageService
    {
        private readonly AdventureStageRepository _adventureStageRepository;

        public AdventureStageService(
            AdventureStageRepository adventureStageRepository)
        {
            _adventureStageRepository = adventureStageRepository;
        }

        public AdventureStageRepository GetAdventureStageRepository()
        {
            return _adventureStageRepository;
        }

        public void ChangeActiveAdventureStageById(int adventureStageModelId)
        {
            
        }
        
    }
}