using LostShadow.Feature.AdventureScene.AdventureStage.Model;
using UnityEngine;
using Zenject;

namespace LostShadow.Feature.AdventureScene.AdventureStage.View
{
    public class AdventureStageView : MonoBehaviour
    {
        [SerializeField] private Sprite _backgroundSprite;

        private AdventureStageModel _adventureStageModel;
        
        [Inject]
        public void Construct(
            AdventureStageModel adventureStageModel)

        {
            _adventureStageModel = adventureStageModel;
        }
        
        void Start()
        {
            
        }
    }
}