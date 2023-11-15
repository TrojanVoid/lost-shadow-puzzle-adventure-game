using Zenject;
using LostShadow.Feature.AdventureScene.AdventureStage.Controller;

namespace LostShadow.Installer
{
    public class AdventureInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<AdventureStageController>().AsSingle().NonLazy();
               
        }
    }
}