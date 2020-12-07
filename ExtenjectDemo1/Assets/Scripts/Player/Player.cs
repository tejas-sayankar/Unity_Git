using UnityEngine;
using System;
using Zenject;

namespace ExtenjectDemo1
{
    public class Player
    {
        SignalBus SignalBus;

        [Inject]
        public void Construct(SignalBus signalBus)
        {
            SignalBus = signalBus;

            SignalBus.Subscribe<TakeDamage>(TakeDamage);
            SignalBus.Subscribe<ScoreUpdate>(UpdateScore);
            SignalBus.Subscribe<StartGame>(Initialize);
            
        }

        float _health = 100.0f;
        public float Health
        {
            get { return _health; }
            set { _health = value; }
        }

        public int Score
        {
            get; set;
        }

        public bool IsDead
        {
            get; set;
        }

        public void Initialize()
        {
            Health = 100.0f;
            Score = 0;

            SignalBus.Fire(new OnHealthUpdated() { NewHealth = Health });
            SignalBus.Fire(new OnScoreUpdated() { NewScore = Score });

        }

        public void TakeDamage(TakeDamage signal)
        {
            Health = Mathf.Max(0.0f, Health - signal.Damage);

            SignalBus.Fire(new OnHealthUpdated() { NewHealth = Health });
            if(Health <= 0 )
            {
                Die();
            }
        }

        public void UpdateScore(ScoreUpdate signal)
        {
            Score += signal.PointsGained;

            SignalBus.Fire(new OnScoreUpdated() { NewScore = Score });
        }

        public void Die()
        {
            SignalBus.Fire<Die>();
        }
    }

}