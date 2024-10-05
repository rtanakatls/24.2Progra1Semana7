using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour, ISubject
{
    private static GameManager instance;

    private List<IObserver> observers = new List<IObserver>();
    private float progression;
    private float timer;

    public static GameManager Instance { get { return instance; } }

    public float Progression { get { return progression; } }

    private void Awake()
    {
        instance = this;
    }

    public void Attach(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (IObserver observer in observers)
        {
            observer.Execute(this);
        }
    }


    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > progression*5)
        {
            progression++;
            Notify();
        }
    }


}
