using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Behaviour1 : IBehaviour
{
    private Rigidbody rb;
    private float speed;

    public Behaviour1(Rigidbody rb,float speed)
    {
        this.rb = rb;
        this.speed = speed;
    }


    public void Execute()
    {
        rb.velocity=Vector3.forward*speed;
    }

}
