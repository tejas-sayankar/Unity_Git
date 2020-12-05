using System;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using Zenject;

public class PlayerHealthComponent : ITickable
{
    readonly Player _player;
    PlayerHealthComponent(
        Player player)
    {
        _player = player;
    }
    public void Tick()
    {
        if (_player.Health <= 0f && !_player.IsDead)
        {
            Die();
        }
    }

    public void Die()
    {
        _player.IsDead = true;
        SceneManager.LoadScene(0);
        //Load scene
    }

    
}
