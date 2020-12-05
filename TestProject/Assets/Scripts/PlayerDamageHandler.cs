using System;
using UnityEngine;

namespace TestDemo1
{
    public class PlayerDamageHandler
    {
        readonly Player _player;
        readonly Settings _settings;

        PlayerDamageHandler(
            Player player,
            Settings settings)
        {
            _player = player;
            _settings = settings;
        }

        public void Damage()
        {
            _player.TakeDamage(_settings.amountOfHealthToReduce);
        }

        [Serializable]
        public class Settings
        {
            public float amountOfHealthToReduce;
        }
    }
}
