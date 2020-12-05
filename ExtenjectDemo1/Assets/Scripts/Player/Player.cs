using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Player : IInitializable
{
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
    }
}
