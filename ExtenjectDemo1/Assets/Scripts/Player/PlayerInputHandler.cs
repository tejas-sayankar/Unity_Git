using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class PlayerInputHandler : MonoBehaviour
{
    private PlayerScoreUpdater _scoreUpdater;
    private PlayerDamageHandler _damageHandler;
    private PlayerHealthComponent _healthComponent;
    
    
    [Inject]
    public void Construct(
        PlayerScoreUpdater scoreUpdater,
        PlayerDamageHandler damageHandler,
        PlayerHealthComponent healthComponent)
    {
        _scoreUpdater = scoreUpdater;
        _damageHandler = damageHandler;
        _healthComponent = healthComponent;
    }

    public void TakeDamage()
    {
        _damageHandler.TakeDamage();
    }

    public void UpdateScore()
    {
        _scoreUpdater.UpdateScore();
    }

    public void Die()
    {
        _healthComponent.Die();
    }
}
