using System;
using UnityEngine;

public class PlayerScoreUpdater
{
    readonly Player _player;
    readonly Settings _settings;

    PlayerScoreUpdater(
        Player player,
        Settings settings)
    {
        _player = player;
        _settings = settings;
    }
    public void UpdateScore()
    {
        _player.Score += _settings.amountOfScoreToUpdate;
    }

    [Serializable]
    public class Settings
    {
        public int amountOfScoreToUpdate;
    }
}
