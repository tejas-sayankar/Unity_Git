using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller<GameInstaller>
{
    public PlayerDamageHandler.Settings DamageHandlerSettings;
    public PlayerScoreUpdater.Settings PlayerScoreUpdater;
    public GUI.Settings GUISettings;
    public override void InstallBindings()
    {
        Container.Bind<Player>().AsSingle().NonLazy();
        Container.BindInterfacesAndSelfTo<PlayerHealthComponent>().AsSingle();
        Container.Bind<PlayerScoreUpdater>().AsSingle();
        Container.Bind<PlayerDamageHandler>().AsSingle();
        Container.BindInterfacesAndSelfTo<GUI>().AsSingle();


        Container.BindInstance(DamageHandlerSettings);
        Container.BindInstance(PlayerScoreUpdater);
        Container.BindInstance(GUISettings);

    }
}