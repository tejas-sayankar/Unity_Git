using System;
using UnityEngine;

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

    public void TakeDamage()
    {
        _player.Health = Mathf.Max(0f, _player.Health - _settings.Damage);
    }

    [Serializable]
    public class Settings
    {
        public int Damage;
    }
}
