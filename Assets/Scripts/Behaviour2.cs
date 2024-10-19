using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class Behaviour2 : IBehaviour
{
    private Transform transform;
    private float timer;

    public Behaviour2(Transform transform)
    {
        timer = 0;
        this.transform = transform;
    }

    public void Execute()
    {
        timer += Time.deltaTime;
        if (transform.localScale.x < timer)
        {
            Vector3 scale = transform.localScale;
            scale += Vector3.one;
            transform.localScale = scale;
        }
    }
}
