using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TestDemo1
{
    public class Player
    {
        float _health = 100.0f;
        int _score = 0;

        public bool IsDead
        {
            get; set;
        }

        public float Health
        {
            get { return _health; }
        }

        public int Score
        {
            get { return _score; }
            set { _score = value; }
        }

        public void TakeDamage(float amount)
        {
            _health = Mathf.Max(0f, _health - amount);
        }
    }
}


