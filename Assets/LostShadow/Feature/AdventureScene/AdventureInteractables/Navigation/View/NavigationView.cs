using System;
using LostShadow.Feature.AdventureScene.AdventureInteractable.Signal;
using LostShadow.Feature.AdventureScene.Navigation.Model;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace LostShadow.Feature.AdventureScene.AdventureInteractable.Navigation.View
{
    public class NavigationView : MonoBehaviour
    {
        [SerializeField] private Button _navigationButton;

        private NavigationModel _navigationModel;
        private SignalBus _signalBus;

        [Inject]
        public void Construct(
            SignalBus signalBus,
            NavigationModel navigationModel)
        {
            _signalBus = signalBus;
            _navigationModel = navigationModel;
        }

        private void OnEnable()
        {
            _navigationButton.onClick.AddListener(OnNavigationButtonClicked);
        }

        private void OnDisable()
        {
            _navigationButton.onClick.RemoveListener(OnNavigationButtonClicked);
        }

        private void OnNavigationButtonClicked()
        {
            _signalBus.Fire<NavigationClickSignal>(new NavigationClickSignal()
            {
                NavigationModel = _navigationModel
            });
        }
    }
}