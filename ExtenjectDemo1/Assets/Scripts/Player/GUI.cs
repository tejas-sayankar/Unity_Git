using System;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class GUI : IInitializable, ITickable
{
    Player _player;
    Settings _settings;

    GUI(
        Player player,
        Settings settings)
    {
        _player = player;
        _settings = settings;
    }

    public void Initialize()
    {
        _settings.healthText.text = "";
        _settings.scoreText.text = "";
        _settings.timerText.text = "";
    }

    public void Tick()
    {
        _settings.healthText.text = _player.Health.ToString();
        _settings.scoreText.text = _player.Score.ToString();
    }

    [Serializable]
    public class Settings
    {
        public Text scoreText;
        public Text healthText;
        public Text timerText;
    }
}
