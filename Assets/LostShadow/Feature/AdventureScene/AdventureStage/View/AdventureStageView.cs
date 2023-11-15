using System;
using System.Collections.Generic;
using LostShadow.Feature.AdventureScene.AdventureInteractable.Model;
using LostShadow.Feature.AdventureScene.AdventureStage.Model;
using UnityEngine;
using Zenject;

namespace LostShadow.Feature.AdventureScene.AdventureStage.View
{
    public class AdventureStageView : MonoBehaviour
    {
        [SerializeField] private GameObject _content;
        [SerializeField] private Sprite _backgroundSprite;
        
        private AdventureStageModel _adventureStageModel;
        private List<AdventureInteractableModel> _interactables;
        
        private SignalBus _signalBus;
        
        [Inject]
        public void Construct(
            AdventureStageModel adventureStageModel,
            SignalBus signalBus)

        {
            _adventureStageModel = adventureStageModel;
            _signalBus = signalBus;
        }

        private void OnDisable()
        {
            
        }

        void Start()
        {
            
        }
    }
}