using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform target;
    private Vector3 offset;

    //Use this for intialization
    void Start()
    {
        offset = transform.position - target.position;
    }

    //Update is called once per frame 
    void Update()
    {
        transform.position = target.position + offset;
    }
}
