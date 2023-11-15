using System.Collections.Generic;
using LostShadow.Feature.AdventureScene.AdventureInteractable.Model;
using LostShadow.Feature.AdventureScene.Navigation.Model;
using UnityEngine;

namespace LostShadow.Feature.AdventureScene.AdventureStage.Model
{
    public class AdventureStageModel
    {
        public int Id;
        
        public Sprite BackgroundSprite;
        public List<AdventureInteractableModel> AdventureInteractableModels;
    }
}