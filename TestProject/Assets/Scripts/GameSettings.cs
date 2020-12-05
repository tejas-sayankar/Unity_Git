using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace TestDemo1
{
    public class GameSettings : ScriptableObjectInstaller<GameSettings>
    {
        // Start is called before the first frame update
        public PlayerSettings Player = null;

        [Serializable]
        public class PlayerSettings
        {
            public PlayerScoreUpdater.Settings PlayerScoreUpdater;
            public PlayerDamageHandler.Settings PlayerDamageHandLer;
        }

        public override void InstallBindings()
        {
            Container.BindInstance(Player.PlayerScoreUpdater).IfNotBound();
            Container.BindInstance(Player.PlayerDamageHandLer).IfNotBound();
        }
    } 
}
