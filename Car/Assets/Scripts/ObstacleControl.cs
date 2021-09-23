using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleControl : MonoBehaviour
{
    public Collider car;
    public GameObject box;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Disappear(car);
    }

    

    public bool isTouching = false;
    public float maxDistance = 5;

    void OnTriggerStay(Collider other)
    {
        // other object is close
        if (Vector3.Distance(other.transform.position, this.transform.position) < maxDistance)
        {
            isTouching = true; // they are touching AND close
        }
        else
        {
            isTouching = false;
        }
    }

    void Disappear(Collider other) {

        if (Vector3.Distance(other.transform.position, this.transform.position) < maxDistance)
        {
            box.SetActive(false);
        }

    }


}
