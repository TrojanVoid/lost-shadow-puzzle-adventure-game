using System.Collections.Generic;
using LostShadow.Feature.AdventureScene.AdventureStage.Model;

namespace LostShadow.Feature.AdventureScene.AdventureStage.Repository
{
    public class AdventureStageRepository
    {
        private List<AdventureStageModel> _adventureStageModels;

        public List<AdventureStageModel> GetAdventureStageModels()
        {
            return _adventureStageModels;
        }

        public AdventureStageModel GetAdventureStageModelById(int id)
        {
            return _adventureStageModels.Find(adventureStageModel => adventureStageModel.Id == id);
        }

        public void AddAdventureStageModel(AdventureStageModel adventureStageModel)
        {
            _adventureStageModels.Add(adventureStageModel);
        }
        
        
    }
}