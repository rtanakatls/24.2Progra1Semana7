using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IObserver
{
    private Rigidbody rb;
    private float speed;

    private void Awake()
    {
        rb= GetComponent<Rigidbody>();  
    }

    private void Start()
    {
        GameManager.Instance.Attach(this);
    }

    public void Execute(ISubject subject)
    {
        if(subject is GameManager)
        {
            speed = ((GameManager)subject).Progression*5;
        }
    }

    private void Update()
    {
        rb.velocity = Vector3.forward * speed;
    }

}
