using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCircle : MonoBehaviour
{
    private Rigidbody rb;
    private float speed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        GameManagerUnity.Instance.OnProgressionChanged += ChangeScale;
    }

    private void ChangeScale(float progression)
    {
        transform.localScale = progression * Vector3.one;
    }
}
