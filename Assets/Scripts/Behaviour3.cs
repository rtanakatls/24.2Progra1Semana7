using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Behaviour3 : IBehaviour
{

    private Transform transform;

    public Behaviour3(Transform transform)
    {
        this.transform = transform;
    }

    public void Execute()
    {
        transform.Rotate(Vector3.one * 360 * Time.deltaTime);
    }
}
