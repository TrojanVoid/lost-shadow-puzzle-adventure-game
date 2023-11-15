using System;
using LostShadow.Feature.AdventureScene.AdventureInteractable.Navigation.Service;
using LostShadow.Feature.AdventureScene.AdventureInteractable.Navigation.View;
using LostShadow.Feature.AdventureScene.AdventureInteractable.Signal;
using LostShadow.Feature.AdventureScene.AdventureStage.Service;
using Zenject;

namespace LostShadow.Feature.AdventureScene.AdventureInteractable.Navigation.Controller
{
    public class NavigationController : IDisposable
    {
        private NavigationView _navigationView;
        private readonly SignalBus _signalBus;
        private readonly AdventureStageService _adventureStageService;
        private readonly NavigationService _navigationService;

        public NavigationController(
            NavigationView navigationView,
            SignalBus signalBus,
            AdventureStageService adventureStageService,
            NavigationService navigationService)
        {
            _navigationView = navigationView;
            _signalBus = signalBus;
            _adventureStageService = adventureStageService;
            _navigationService = navigationService;
            
            _signalBus.Subscribe<NavigationClickSignal>(OnNavigationClickSignal);
        }

        public void Dispose()
        {
            _signalBus.Unsubscribe<NavigationClickSignal>(OnNavigationClickSignal);
        }

        public void OnNavigationClickSignal(NavigationClickSignal signal)
        {
            _adventureStageService.ChangeActiveAdventureStageById(
                _navigationService.GetAdventureStageModelFromNavigationModel(
                    signal.NavigationModel)
                    .Id);
        }
        
    }
}