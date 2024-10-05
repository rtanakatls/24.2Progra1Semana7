using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUnity : MonoBehaviour
{
    private Rigidbody rb;
    private float speed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        GameManagerUnity.Instance.OnProgressionChanged += ChangeSpeed;
    }

    private void ChangeSpeed(float progression)
    {
        speed = progression * 5;
    }

    private void Update()
    {
        rb.velocity = Vector3.forward * speed;
    }
}
