using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerUnity : MonoBehaviour
{
    private static GameManagerUnity instance;

    public event Action<float> OnProgressionChanged;

    private float progression;
    private float timer;

    public static GameManagerUnity Instance { get { return instance; } }


    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > progression * 5)
        {
            progression++;
            OnProgressionChanged?.Invoke(progression);
        }
    }
}
