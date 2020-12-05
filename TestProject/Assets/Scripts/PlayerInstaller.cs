using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace TestDemo1
{
    public class PlayerInstaller : MonoInstaller
    {

        public override void InstallBindings()
        {
            Container.Bind<Player>().AsSingle();
            Container.Bind<PlayerScoreUpdater>().AsSingle();
            Container.Bind<PlayerHealthHandler>().AsSingle();
            Container.Bind<PlayerDamageHandler>().AsSingle();
        }

  
    } 
}
