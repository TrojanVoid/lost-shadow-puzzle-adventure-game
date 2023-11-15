using System.Collections.Generic;
using LostShadow.Feature.AdventureScene.Navigation.Model;

namespace LostShadow.Feature.AdventureScene.AdventureInteractables.Navigation.NavigationRepository
{
    public class NavigationRepository
    {
        private List<NavigationModel> _navigationModels;

        public List<NavigationModel> GetNavigationModels()
        {
            return _navigationModels;
        }

        public void AddNavigationModel(NavigationModel navigationModel)
        {
            _navigationModels.Add(navigationModel);
        }
    }
}