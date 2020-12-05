using System;
using UnityEngine;
using Zenject;

namespace TestDemo1
{
    public class PlayerHealthHandler : ITickable
    {
        readonly Player _player;

        public PlayerHealthHandler(
            Player player)
        {
            _player = player;
        }
        public void Tick()
        {
            if (_player.Health >= 0f && !_player.IsDead)
            {
                Die();
            }
        }

        public void Die()
        {
            _player.IsDead = true;
            //Load Scene
        }
    }

}