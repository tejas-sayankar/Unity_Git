using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace TestDemo1
{
    public class GameController : IInitializable
    {
        readonly Player _player;

        float _elapsedTime;

        public GameController(
            Player player)
        {
            _player = player;
        }

        public float ElapsedTime
        {
            get { return _elapsedTime; }
        }

        public void EnableMainMenu()
        {
            //Enable MainMenu
            _elapsedTime = 0.0f;
        }

        public void StartGame()
        {
            //Enable Game
        }

        public void Initialize()
        {
            EnableMainMenu();
        }
    }

}