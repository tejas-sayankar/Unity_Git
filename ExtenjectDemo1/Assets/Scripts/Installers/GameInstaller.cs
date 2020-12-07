using Zenject;

namespace ExtenjectDemo1
{
    public class GameInstaller : MonoInstaller<GameInstaller>
    {
        public GameView.Settings Settings;
        public override void InstallBindings()
        {
            SignalBusInstaller.Install(Container);

            Container.DeclareSignal<TakeDamage>();
            Container.DeclareSignal<ScoreUpdate>();

            Container.DeclareSignal<OnHealthUpdated>().OptionalSubscriber();
            Container.DeclareSignal<OnScoreUpdated>().OptionalSubscriber();

            Container.DeclareSignal<Die>();
            Container.DeclareSignal<StartGame>();

            Container.Bind<Player>().AsSingle().NonLazy();

            Container.BindInstance(Settings);

            

        }
    } 
}