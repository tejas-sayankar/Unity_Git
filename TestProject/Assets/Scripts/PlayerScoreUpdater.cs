using System;
using UnityEngine;
using Zenject;

namespace TestDemo1
{
    public class PlayerScoreUpdater
    {
        readonly Player _player;
        readonly Settings _settings;

        public PlayerScoreUpdater(
            Player player,
            Settings settings)
        {
            _player = player;
            _settings = settings;
        }
        
        
        public void UpdateScore()
        {
            _player.Score += _settings.points;
        }
        

        [Serializable]
        public class Settings
        {
            public int points;
        }
    }

}