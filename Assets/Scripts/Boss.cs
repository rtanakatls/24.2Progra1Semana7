using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    private IBehaviour strategy;


    private void Awake()
    {
        StartCoroutine(HandleBehaviours());
    }

    IEnumerator HandleBehaviours()
    {
        strategy = new Behaviour1(GetComponent<Rigidbody>(), 5);
        yield return new WaitForSeconds(5);
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        strategy = new Behaviour2(transform);
        yield return new WaitForSeconds(5);
        strategy = new Behaviour3(transform);

    }


    private void Update()
    {
        strategy.Execute();
    }

}
